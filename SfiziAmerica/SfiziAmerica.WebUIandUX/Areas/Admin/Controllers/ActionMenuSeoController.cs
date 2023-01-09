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
    public class ActionMenuSeoController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMenuSeoController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/seo-yonetimi-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.menuSeoRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/seo-yonetimi-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/seo-yonetimi-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddMenuSeoViewDTO addMenuSeoViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool cateringExist = await unitOfWork.menuSeoRepository.AnyAsync(x => x.PageName.ToLower() == addMenuSeoViewDTO.PageName.ToLower());
            if (cateringExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            MenuSeo menuSeo = addMenuSeoViewDTO.Adapt<MenuSeo>();
            menuSeo.seoDesign = "ImproBioTech and Infromation Technology";
            menuSeo.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menuSeo.seoAuthor = "ImproBioTech and Information Technology";
            menuSeo.seoSubject = "Restaurant";
            await unitOfWork.menuSeoRepository.AddAsync(menuSeo);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/seo-yonetimi-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var menuSeo = await unitOfWork.menuSeoRepository.GetAsync(x => x.ID == id);
            if (menuSeo == null)
                return RedirectToAction("Index");;
            updateMenuSeoViewModel updateMenuSeoViewModel = new() { MenuSeo = menuSeo };
            return View(updateMenuSeoViewModel);
        }

        [Route("admin/seo-yonetimi-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMenuSeoViewDTO updateMenuSeoViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });

            bool menuSeoExist = await unitOfWork.menuSeoRepository.AnyAsync(x => x.PageName.ToLower() == updateMenuSeoViewDTO.PageName.ToLower() && x.ID != updateMenuSeoViewDTO.ID);
            if (menuSeoExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            var menuSeo = await unitOfWork.menuSeoRepository.GetAsync(x => x.ID == updateMenuSeoViewDTO.ID);
            if (menuSeo == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            menuSeo.PageName = updateMenuSeoViewDTO.PageName;
            menuSeo.IsActive = updateMenuSeoViewDTO.IsActive;
            #region seo
            menuSeo.seoDescription = updateMenuSeoViewDTO.seoDescription;
            menuSeo.seoFacebookDescription = updateMenuSeoViewDTO.seoFacebookDescription;
            menuSeo.seoFacebookKeywrods = updateMenuSeoViewDTO.seoFacebookKeywrods;
            menuSeo.seoFacebookTitle = updateMenuSeoViewDTO.seoFacebookTitle;
            menuSeo.seoFacebookUrl = updateMenuSeoViewDTO.seoFacebookUrl;
            menuSeo.seoReply = updateMenuSeoViewDTO.seoReply;
            menuSeo.seoTitle = updateMenuSeoViewDTO.seoTitle;
            menuSeo.seoKeywords = updateMenuSeoViewDTO.seoKeywords;
            menuSeo.seoTwitterDescription = updateMenuSeoViewDTO.seoTwitterDescription;
            menuSeo.seoTwitterKeywords = updateMenuSeoViewDTO.seoTwitterKeywords;
            menuSeo.seoTwitterTitle = updateMenuSeoViewDTO.seoTwitterTitle;
            menuSeo.seoTwitterUrl = updateMenuSeoViewDTO.seoTwitterUrl;
            menuSeo.seoDesign = "ImproBioTech and Infromation Technology";
            menuSeo.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menuSeo.seoAuthor = "ImproBioTech and Information Technology";
            menuSeo.seoSubject = "Restaurant";
            #endregion
            await unitOfWork.menuSeoRepository.UpdateAsync(menuSeo);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/seo-yonetimi-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.menuSeoRepository.GetAsync(x => x.ID == id);
            if (fle == null)
                return NotFound();
            await unitOfWork.menuSeoRepository.DeleteAsync(fle);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
