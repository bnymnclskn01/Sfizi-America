using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.Helper;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionSliderController : Controller
    {
        DbContext context = new SfizilDatabaseModelContext();
        UnitOfWork unitOfWork;
        public ActionSliderController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/slider-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.sliderRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/slider-ekle")]
        public IActionResult Create() 
        {
            return View();
        }
        [Route("admin/slider-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddSliderDTO addSliderDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });

            bool sliderExist = await unitOfWork.sliderRepository.AnyAsync(x => x.Title.ToLower() == addSliderDTO.Title.ToLower());

            if (sliderExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            Slider slider = addSliderDTO.Adapt<Slider>();
            if (addSliderDTO.ImageVideoUrl != null)
            {
                string imgPath = VideoHelper.CreateVideo(addSliderDTO.ImageVideoUrl, "Slider");
                if (imgPath == string.Empty)
                    return BadRequest();
                slider.ImageVideoUrl = imgPath;
            }
            await unitOfWork.sliderRepository.AddAsync(slider);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/slider-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var slider = await unitOfWork.sliderRepository.GetAsync(x => x.ID == id);
            if (slider == null)
                return RedirectToAction("Index");
            updateSliderViewModel updateSliderViewModel = new() { Slider = slider };
            return View(updateSliderViewModel);
        }

        [Route("admin/slider-guncelle")]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateSliderDTO updateSliderDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });

            var slider = await unitOfWork.sliderRepository.GetAsync(x => x.ID == updateSliderDTO.ID);

            if (slider == null)
                return NotFound(new { errorMessage = "Bu kayıta ait bilgi bulunmamaktadır" });

            bool aboutExist = await unitOfWork.sliderRepository
                .AnyAsync(x => x.Title.ToLower() == updateSliderDTO.Title.ToLower() && x.ID != updateSliderDTO.ID);

            if (aboutExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            if (updateSliderDTO.ImageVideoUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Slider/" + slider.ImageVideoUrl))
                    System.IO.File.Delete("wwwroot/Image/Slider/" + slider.ImageVideoUrl);

                string imgPath = ImageHelper.CreateImage(updateSliderDTO.ImageVideoUrl, "Slider");

                if (imgPath == string.Empty)
                    return BadRequest();

                slider.ImageVideoUrl = imgPath;
            }
            slider.Title = updateSliderDTO.Title;
            slider.IsActive = updateSliderDTO.IsActive;
            slider.ID = updateSliderDTO.ID;
            slider.Description = updateSliderDTO.Description;
            slider.LastDate = DateTime.Now;
            await unitOfWork.sliderRepository.UpdateAsync(slider);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/slider-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var slider = await unitOfWork.sliderRepository.GetAsync(x => x.ID == id);
            if (slider == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Slider/" + slider.ImageVideoUrl))
                System.IO.File.Delete("wwwroot/Image/Slider/" + slider.ImageVideoUrl);
            await unitOfWork.sliderRepository.DeleteAsync(slider);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
