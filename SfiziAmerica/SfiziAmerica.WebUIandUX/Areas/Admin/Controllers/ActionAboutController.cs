using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
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
    public class ActionAboutController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionAboutController()
        {
            unitOfWork = new(context);
        }
        [Route("admin/hakkimizda-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.aboutRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/hakkimizda-ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/hakkimizda-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddAboutDTO addAboutDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool aboutExist = await unitOfWork.aboutRepository.AnyAsync(x => x.Title.ToLower() == addAboutDTO.Title.ToLower());
            if (aboutExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            About about = addAboutDTO.Adapt<About>();
            if (addAboutDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addAboutDTO.ImageUrl, "About");
                if (imgPath == string.Empty)
                    return BadRequest();
                about.ImageUrl = imgPath;
            }
            await unitOfWork.aboutRepository.AddAsync(about);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/hakkimizda-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.ID == id);
            if (about == null)
                return RedirectToAction("Index");
            updateAboutViewModel updateAboutViewModel = new() { About = about};
            return View(updateAboutViewModel);
        }

        [Route("admin/hakkimizda-guncelle")]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateAboutDTO updateAboutDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.ID == updateAboutDTO.ID);
            if (about == null)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            bool aboutExist = await unitOfWork.aboutRepository.AnyAsync(x => x.Title.ToLower() == updateAboutDTO.Title.ToLower() && x.ID != updateAboutDTO.ID);
            if (aboutExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            if (updateAboutDTO.ImageUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/About/" + about.ImageUrl))
                    System.IO.File.Delete("wwwroot/Image/About/" + about.ImageUrl);
                string imgPath = ImageHelper.CreateImage(updateAboutDTO.ImageUrl, "About");
                if (imgPath == string.Empty)
                    return BadRequest();
                about.ImageUrl = imgPath;
            }
            about.Title = updateAboutDTO.Title;
            about.IsActive = updateAboutDTO.IsActive;
            about.ID = updateAboutDTO.ID;
            about.Description = updateAboutDTO.Description;
            about.ShortDescription = updateAboutDTO.ShortDescription;
            about.LastDate = DateTime.Now;
            await unitOfWork.aboutRepository.UpdateAsync(about);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/hakkimizda-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.ID == id);
            if (about == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/About/" + about.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/About/" + about.ImageUrl);
            await unitOfWork.aboutRepository.DeleteAsync(about);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
