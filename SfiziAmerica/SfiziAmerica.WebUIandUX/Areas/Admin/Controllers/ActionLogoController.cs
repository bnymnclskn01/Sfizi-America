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
    public class ActionLogoController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionLogoController()
        {
            unitOfWork = new(context);
        }


        #region Listele
        [Route("admin/logo-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.logoRepository.GetAllAsync();
            return View(model);
        }
        #endregion

        #region Ekle
        [Route("admin/logo-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/logo-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddLogoViewDTO addLogoViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool logoExist = await unitOfWork.logoRepository.AnyAsync(x => x.Title.ToLower() == addLogoViewDTO.Title.ToLower());
            if (logoExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            Logo logo = addLogoViewDTO.Adapt<Logo>();
            if (addLogoViewDTO.LogoUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addLogoViewDTO.LogoUrl, "Logo");
                if (imgPath == string.Empty)
                    return BadRequest();
                logo.LogoUrl = imgPath;
            }
            await unitOfWork.logoRepository.AddAsync(logo);
            await unitOfWork.SaveAsync();
            return Ok();
        }
        #endregion

        #region Güncelle
        [Route("admin/logo-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var logo = await unitOfWork.logoRepository.GetAsync(x => x.ID == id);
            if (logo == null)
                return RedirectToAction("Index");
            UpdateLogoViewModel updateLogoViewModel = new() { Logo = logo };
            return View(updateLogoViewModel);
        }

        [Route("admin/logo-guncelle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Edit(UpdateLogoViewDTO updateLogoViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            var logo = await unitOfWork.logoRepository.GetAsync(x => x.ID == updateLogoViewDTO.ID);
            if (logo == null)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            bool logoExist= await unitOfWork.logoRepository.AnyAsync(x => x.Title.ToLower() == updateLogoViewDTO.Title.ToLower() && x.ID != updateLogoViewDTO.ID);
            if (logoExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            if (updateLogoViewDTO.LogoUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Logo/" + logo.LogoUrl))
                    System.IO.File.Delete("wwwroot/Image/Logo/" + logo.LogoUrl);
                string imgPath = ImageHelper.CreateImage(updateLogoViewDTO.LogoUrl, "Logo");
                if (imgPath == string.Empty)
                    return BadRequest();
                logo.LogoUrl = imgPath;
            }
            logo.ID = updateLogoViewDTO.ID;
            logo.Title = updateLogoViewDTO.Title;
            logo.LastDate = DateTime.Now;
            logo.ImageAltTag= updateLogoViewDTO.ImageAltTag;
            logo.IsActive = updateLogoViewDTO.IsActive;
            await unitOfWork.logoRepository.UpdateAsync(logo);
            await unitOfWork.SaveAsync();
            return Ok();
        }
        #endregion

        #region Sil
        [Route("admin/logo-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var logo = await unitOfWork.logoRepository.GetAsync(x => x.ID == id);
            if (logo == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Logo/" + logo.LogoUrl))
                System.IO.File.Delete("wwwroot/Image/Logo/" + logo.LogoUrl);
            await unitOfWork.logoRepository.DeleteAsync(logo);
            await unitOfWork.SaveAsync();
            return Ok();
        }
        #endregion
    }
}
