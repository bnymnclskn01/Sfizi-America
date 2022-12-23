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
    public class ActionVisionController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionVisionController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/vizyon-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.visionRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/vizyon-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/vizyon-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddVisionDTO addVisionDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            bool visionnExist = await unitOfWork.visionRepository.AnyAsync(x => x.Title.ToLower() == addVisionDTO.Title.ToLower());
            if (visionnExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            Vision vision = addVisionDTO.Adapt<Vision>();
            if (addVisionDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addVisionDTO.ImageUrl, "Vision");
                if (imgPath == string.Empty)
                    return BadRequest();
                vision.ImageUrl = imgPath;
            }
            await unitOfWork.visionRepository.AddAsync(vision);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/vizyon-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var vision = await unitOfWork.visionRepository.GetAsync(x => x.ID == id);
            if (vision == null)
                return RedirectToAction("Index");
            updateVisionViewModel updateVisionViewModel = new() { Vision = vision};
            return View(updateVisionViewModel);
        }

        [Route("admin/vizyon-guncelle")]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateVisionDTO updateVisionDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            var vision = await unitOfWork.visionRepository.GetAsync(x => x.ID == updateVisionDTO.ID);
            if (vision == null)
                return NotFound(new { errorMessage = "Bu kayıta ait bilgi bulunmamaktadır" });
            bool visionExist = await unitOfWork.visionRepository.AnyAsync(x => x.Title.ToLower() == updateVisionDTO.Title.ToLower() && x.ID != updateVisionDTO.ID);
            if (visionExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            if (updateVisionDTO.ImageUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Vision/" + vision.ImageUrl))
                    System.IO.File.Delete("wwwroot/Image/Vision/" + vision.ImageUrl);
                string imgPath = ImageHelper.CreateImage(updateVisionDTO.ImageUrl, "Vision");
                if (imgPath == string.Empty)
                    return BadRequest();
                vision.ImageUrl = imgPath;
            }
            vision.Title = updateVisionDTO.Title;
            vision.IsActive = updateVisionDTO.IsActive;
            vision.ID = updateVisionDTO.ID;
            vision.Description = updateVisionDTO.Description;
            vision.ShortDescription = updateVisionDTO.ShortDescription;
            vision.LastDate = DateTime.Now;
            await unitOfWork.visionRepository.UpdateAsync(vision);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/vizyon-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var vision = await unitOfWork.visionRepository.GetAsync(x => x.ID == id);
            if (vision == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Vision/" + vision.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/Vision/" + vision.ImageUrl);
            await unitOfWork.visionRepository.DeleteAsync(vision);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
