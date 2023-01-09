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
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionMenuController : Controller
    {
        private SfizilDatabaseModelContext SfizilDatabase = new SfizilDatabaseModelContext();
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMenuController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/menu-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await SfizilDatabase.Menus.Include(x=>x.CategoryMenus).ThenInclude(x=>x.MenuCategory).ToListAsync();
            return View(model);
        }

        [Route("admin/menu-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var MenuCategoryList = await unitOfWork.menuCategoryRepository.GetAllAsync(x=>x.IsActive==true,x=>x.CategoryMenus);
            return View(MenuCategoryList);
        }

        [Route("admin/menu-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddMenuViewDTO addMenuViewDTO, Guid[] MenuCategoryID)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool menuExist = await unitOfWork.menuRepository.AnyAsync(x => x.Title.ToLower() == addMenuViewDTO.Title.ToLower());
            if (menuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            Menu menu = addMenuViewDTO.Adapt<Menu>();
            #region Image
            if (addMenuViewDTO.ImageUrl1 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuViewDTO.ImageUrl1, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menu.ImageUrl1 = imgPath;
            }
            if (addMenuViewDTO.ImageUrl2 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuViewDTO.ImageUrl2, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menu.ImageUrl2 = imgPath;
            }
            if (addMenuViewDTO.ImageUrl3 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuViewDTO.ImageUrl3, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menu.ImageUrl3 = imgPath;
            }
            if (addMenuViewDTO.ImageUrl4 != null)
            {
                string imgPath = ImageHelper.CreateImage(addMenuViewDTO.ImageUrl4, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest();
                menu.ImageUrl4 = imgPath;
            }
            #endregion
            menu.seoDesign = "ImproBioTech and Infromation Technology";
            menu.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menu.seoAuthor = "ImproBioTech and Information Technology";
            menu.seoSubject = "Restaurant";
            menu.Slug = StringHelper.StringReplacer(addMenuViewDTO.Title).ToLower();
            decimal sonuc = Convert.ToDecimal(((addMenuViewDTO.Price * addMenuViewDTO.Discount) / 100) + addMenuViewDTO.Price);
            if (addMenuViewDTO.Discount == 0 || addMenuViewDTO.Discount > 0)
            {
                menu.Price = addMenuViewDTO.Price;
            }
            else
            {
                menu.DiscountPrice = sonuc;
            }
            await unitOfWork.menuRepository.AddAsync(menu);
            await unitOfWork.SaveAsync();
            foreach (Guid item in MenuCategoryID)
            {
                CategoryMenu menuCategory = new CategoryMenu();
                menuCategory.MenuCategoryID = item;
                menuCategory.MenuID = menu.ID;
                menuCategory.CreateDate = DateTime.Now;
                menuCategory.LastDate = DateTime.Now;
                menuCategory.IsActive = menu.IsActive;
                await unitOfWork.categoryMenuRepository.AddAsync(menuCategory);
                await unitOfWork.SaveAsync();
            }
            return Ok();
        }

        [Route("admin/menu-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var menu = await SfizilDatabase.Menus.Include(x=>x.CategoryMenus).ThenInclude(x=>x.MenuCategory).Where(x=>x.ID==id).FirstOrDefaultAsync();
            if (menu == null)
                return RedirectToAction("Index");
            var MenuCategoryList= await unitOfWork.menuCategoryRepository.GetAllAsync(x => x.IsActive == true, x => x.CategoryMenus);
            updateMenuViewModel updateMenuViewModel = new() { MenuCategories = MenuCategoryList, Menu = menu };
            return View(updateMenuViewModel);
        }

        [Route("admin/menu-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMenuViewDTO updateMenuViewDTO, Guid[] MenuCategoryID)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            bool MenuExist = await unitOfWork.menuRepository.AnyAsync(x => x.Title.ToLower() == updateMenuViewDTO.Title.ToLower() && x.ID != updateMenuViewDTO.ID);
            if (MenuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            var menu = await unitOfWork.menuRepository.GetAsync(x => x.ID == updateMenuViewDTO.ID);
            if (menu == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            #region Image
            if (updateMenuViewDTO.ImageUrl1 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menu.ImageUrl1))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menu.ImageUrl1);
                string imgPath = ImageHelper.CreateImage(updateMenuViewDTO.ImageUrl1, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menu.ImageUrl1 = imgPath;
            }
            if (updateMenuViewDTO.ImageUrl2 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menu.ImageUrl2))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menu.ImageUrl2);
                string imgPath = ImageHelper.CreateImage(updateMenuViewDTO.ImageUrl2, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menu.ImageUrl2 = imgPath;
            }
            if (updateMenuViewDTO.ImageUrl3 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menu.ImageUrl3))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menu.ImageUrl3);
                string imgPath = ImageHelper.CreateImage(updateMenuViewDTO.ImageUrl3, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menu.ImageUrl3 = imgPath;
            }
            if (updateMenuViewDTO.ImageUrl4 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Menu/" + menu.ImageUrl4))
                    System.IO.File.Delete("wwwroot/Image/Menu/" + menu.ImageUrl4);
                string imgPath = ImageHelper.CreateImage(updateMenuViewDTO.ImageUrl4, "Menu");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                menu.ImageUrl4 = imgPath;
            }
            #endregion
            #region updateMenuViewDTO
            menu.Title = updateMenuViewDTO.Title;
            menu.ShortDescription = updateMenuViewDTO.ShortDescription;
            menu.Description = updateMenuViewDTO.Description;
            menu.Price = updateMenuViewDTO.Price;
            menu.Discount = Convert.ToDecimal(updateMenuViewDTO.Discount);
            if (updateMenuViewDTO.Discount == 0)
            {
                menu.DiscountPrice = 0;
            }
            else
            {
                menu.DiscountPrice = menu.Price - (menu.Price / menu.Discount);
            }
            menu.IsActive = updateMenuViewDTO.IsActive;
            menu.LastDate = DateTime.Now;
            #endregion
            #region seo
            menu.seoDescription = updateMenuViewDTO.seoDescription;
            menu.seoFacebookDescription = updateMenuViewDTO.seoFacebookDescription;
            menu.seoFacebookKeywrods = updateMenuViewDTO.seoFacebookKeywrods;
            menu.seoFacebookTitle = updateMenuViewDTO.seoFacebookTitle;
            menu.seoFacebookUrl = updateMenuViewDTO.seoFacebookUrl;
            menu.seoReply = updateMenuViewDTO.seoReply;
            menu.seoTitle = updateMenuViewDTO.seoTitle;
            menu.seoKeywords = updateMenuViewDTO.seoKeywords;
            menu.seoTwitterDescription = updateMenuViewDTO.seoTwitterDescription;
            menu.seoTwitterKeywords = updateMenuViewDTO.seoTwitterKeywords;
            menu.seoTwitterTitle = updateMenuViewDTO.seoTwitterTitle;
            menu.seoTwitterUrl = updateMenuViewDTO.seoTwitterUrl;
            menu.seoDesign = "ImproBioTech and Infromation Technology";
            menu.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            menu.seoAuthor = "ImproBioTech and Information Technology";
            menu.seoSubject = "Restaurant";
            menu.Slug = StringHelper.StringReplacer(updateMenuViewDTO.Title).ToLower();
            #endregion
            await unitOfWork.menuRepository.UpdateAsync(menu);
            await unitOfWork.SaveAsync();
            foreach (Guid item in MenuCategoryID)
            {
                CategoryMenu menuCategory = new CategoryMenu();
                menuCategory.MenuCategoryID = item;
                menuCategory.MenuID = menu.ID;
                menuCategory.LastDate = DateTime.Now;
                menuCategory.IsActive = menu.IsActive;
                await unitOfWork.categoryMenuRepository.UpdateAsync(menuCategory);
                await unitOfWork.SaveAsync();
            }
            return Ok();
        }

        [Route("admin/menu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.menuRepository.GetAsync(x => x.ID == id);
            var model = await unitOfWork.categoryMenuRepository.GetAllAsync(x => x.MenuID == fle.ID);
            await unitOfWork.menuRepository.DeleteAsync(fle);
            if (fle == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl1))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl1);
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl2))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl2);
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl3))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl3);
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl4))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl4);
            foreach (var item in model)
            {
                await unitOfWork.categoryMenuRepository.DeleteAsync(item);
                await unitOfWork.SaveAsync();
            }
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
