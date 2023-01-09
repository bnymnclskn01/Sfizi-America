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
    public class ActionMenuCategoryController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMenuCategoryController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/menu-kategori-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.menuCategoryRepository.GetAllAsync(null,x=>x.ParentMenuCategory);
            return View(model);
        }


        [Route("admin/menu-kategori-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var parentMenuCategoryList = await unitOfWork.menuCategoryRepository.GetAllAsync();
            return View(parentMenuCategoryList);
        }

        [Route("admin/menu-kategori-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddMenuCategoryViewDTO addMenuCategoryViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool cateringMenuExist = await unitOfWork.menuCategoryRepository.AnyAsync(x => x.Title.ToLower() == addMenuCategoryViewDTO.Title.ToLower());
            if (cateringMenuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            MenuCategory menuCategory=addMenuCategoryViewDTO.Adapt<MenuCategory>();
            if (addMenuCategoryViewDTO.ImageUrl1 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuCategoryViewDTO.ImageUrl1, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menuCategory.ImageUrl1 = imgPath;
            }
            if (addMenuCategoryViewDTO.ImageUrl2 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuCategoryViewDTO.ImageUrl2, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menuCategory.ImageUrl2 = imgPath;
            }
            menuCategory.seoDesign = "ImproBioTech and Infromation Technology";
            menuCategory.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menuCategory.seoAuthor = "ImproBioTech and Information Technology";
            menuCategory.seoSubject = "Restaurant";
            menuCategory.Slug = StringHelper.StringReplacer(menuCategory.Title).ToLower();
            await unitOfWork.menuCategoryRepository.AddAsync(menuCategory);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/menu-kategori-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var menuCategory = await unitOfWork.menuCategoryRepository.GetAsync(x => x.ID == id, x => x.ParentMenuCategory);
            if (menuCategory == null)
                return RedirectToAction("Index");
            var parentMenuCategoryList = await unitOfWork.menuCategoryRepository.GetAllAsync();
            updateMenuCategoryViewModel updateMenuCategoryViewModel = new() { MenuCategory = menuCategory, MenuCategories = parentMenuCategoryList };
            return View(updateMenuCategoryViewModel);
        }

        [Route("admin/menu-kategori-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMenuCategory updateMenuCategory)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            bool menuCategoryExist = await unitOfWork.menuCategoryRepository.AnyAsync(x => x.Title.ToLower() == updateMenuCategory.Title.ToLower() && x.ID != updateMenuCategory.ID);
            if (menuCategoryExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            var menuCategory = await unitOfWork.menuCategoryRepository.GetAsync(x => x.ID == updateMenuCategory.ID);
            if (menuCategory == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            if (updateMenuCategory.ImageUrl1 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menuCategory.ImageUrl1))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menuCategory.ImageUrl1);
                string imgPath = ImageHelper.CreateImage(updateMenuCategory.ImageUrl1, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menuCategory.ImageUrl1 = imgPath;
            }
            if (updateMenuCategory.ImageUrl2 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menuCategory.ImageUrl2))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menuCategory.ImageUrl2);
                string imgPath = ImageHelper.CreateImage(updateMenuCategory.ImageUrl2, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menuCategory.ImageUrl2 = imgPath;
            }
            menuCategory.Rank = updateMenuCategory.Rank;
            menuCategory.Title = updateMenuCategory.Title;
            menuCategory.ShortDescription = updateMenuCategory.ShortDescription;
            menuCategory.Description = updateMenuCategory.Description;
            menuCategory.MenuCategoryID = updateMenuCategory.MenuCategoryID;

            menuCategory.IsActive = updateMenuCategory.IsActive;
            menuCategory.LastDate = DateTime.Now;
            #region seo
            menuCategory.seoDescription = updateMenuCategory.seoDescription;
            menuCategory.seoFacebookDescription = updateMenuCategory.seoFacebookDescription;
            menuCategory.seoFacebookKeywrods = updateMenuCategory.seoFacebookKeywrods;
            menuCategory.seoFacebookTitle = updateMenuCategory.seoFacebookTitle;
            menuCategory.seoFacebookUrl = updateMenuCategory.seoFacebookUrl;
            menuCategory.seoReply = updateMenuCategory.seoReply;
            menuCategory.seoTitle = updateMenuCategory.seoTitle;
            menuCategory.seoKeywords = updateMenuCategory.seoKeywords;
            menuCategory.seoTwitterDescription = updateMenuCategory.seoTwitterDescription;
            menuCategory.seoTwitterKeywords = updateMenuCategory.seoTwitterKeywords;
            menuCategory.seoTwitterTitle = updateMenuCategory.seoTwitterTitle;
            menuCategory.seoTwitterUrl = updateMenuCategory.seoTwitterUrl;
            menuCategory.seoDesign = "ImproBioTech and Infromation Technology";
            menuCategory.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menuCategory.seoAuthor = "ImproBioTech and Information Technology";
            menuCategory.seoSubject = "Restaurant";
            menuCategory.Slug = StringHelper.StringReplacer(updateMenuCategory.Title).ToLower();
            #endregion
            await unitOfWork.menuCategoryRepository.UpdateAsync(menuCategory);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/menu-kategori-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.menuCategoryRepository.GetAsync(x => x.ID == id);
            var model = await unitOfWork.menuCategoryRepository.GetAllAsync(x => x.MenuCategoryID == fle.ID);
            if (fle == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl1))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl1);
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl2))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl2);
            await unitOfWork.menuCategoryRepository.DeleteAsync(fle);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
