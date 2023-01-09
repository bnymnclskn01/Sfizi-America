using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.Helper;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
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
