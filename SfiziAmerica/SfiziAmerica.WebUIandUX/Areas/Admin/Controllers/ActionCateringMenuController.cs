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
    public class ActionCateringMenuController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionCateringMenuController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/catering-menu-Listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.cateringMenuRepository.GetAllAsync(null, x => x.Catering);
            return View(model);
        }

        [Route("admin/catering-menu-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var CateringList = await unitOfWork.cateringRepository.GetAllAsync();
            return View(CateringList);
        }

        [Route("admin/catering-menu-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddCateringMenuViewDTO addCateringMenuViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool cateringMenuExist = await unitOfWork.cateringMenuRepository.AnyAsync(x => x.Title.ToLower() == addCateringMenuViewDTO.Title.ToLower());
            if (cateringMenuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            CateringMenu cateringMenu = addCateringMenuViewDTO.Adapt<CateringMenu>();
            #region Image
            if (addCateringMenuViewDTO.ImageUrl1 != null)
            {
                string imgPath = ImageHelper.CreateImage(addCateringMenuViewDTO.ImageUrl1, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest();
                cateringMenu.ImageUrl1 = imgPath;
            }
            if (addCateringMenuViewDTO.ImageUrl2 != null)
            {
                string imgPath = ImageHelper.CreateImage(addCateringMenuViewDTO.ImageUrl2, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest();
                cateringMenu.ImageUrl2 = imgPath;
            }
            if (addCateringMenuViewDTO.ImageUrl3 != null)
            {
                string imgPath = ImageHelper.CreateImage(addCateringMenuViewDTO.ImageUrl3, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest();
                cateringMenu.ImageUrl3 = imgPath;
            }
            if (addCateringMenuViewDTO.ImageUrl4 != null)
            {
                string imgPath = ImageHelper.CreateImage(addCateringMenuViewDTO.ImageUrl4, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest();
                cateringMenu.ImageUrl4 = imgPath;
            }
            #endregion
            cateringMenu.seoDesign = "ImproBioTech and Infromation Technology";
            cateringMenu.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            cateringMenu.seoAuthor = "ImproBioTech and Information Technology";
            cateringMenu.seoSubject = "Restaurant";
            if (addCateringMenuViewDTO.Discount == 0)
            {
                cateringMenu.DiscountPrice = 0;
            }
            else
            {
                cateringMenu.DiscountPrice = cateringMenu.Price - (cateringMenu.Price / cateringMenu.Discount);
            }
            await unitOfWork.cateringMenuRepository.AddAsync(cateringMenu);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/catering-menu-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var cateringMenu = await unitOfWork.cateringMenuRepository.GetAsync(x => x.ID == id, x => x.Catering);
            if (cateringMenu == null)
                return RedirectToAction("Index");
            var caterings = await unitOfWork.cateringRepository.GetAllAsync();
            updateCateringMenuViewModel updateCateringMenuViewModel = new() { CateringMenu = cateringMenu, Caterings = caterings };
            return View(updateCateringMenuViewModel);
        }

        [Route("admin/catering-menu-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCateringMenuViewDTO updateCateringMenuViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });

            bool cateringMenuExist = await unitOfWork.cateringMenuRepository.AnyAsync(x => x.Title.ToLower() == updateCateringMenuViewDTO.Title.ToLower() && x.ID != updateCateringMenuViewDTO.ID);
            if (cateringMenuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            var cateringMenu = await unitOfWork.cateringMenuRepository.GetAsync(x => x.ID == updateCateringMenuViewDTO.ID);
            if (cateringMenu == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            #region Image
            if (updateCateringMenuViewDTO.ImageUrl1 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + cateringMenu.ImageUrl1))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + cateringMenu.ImageUrl1);
                string imgPath = ImageHelper.CreateImage(updateCateringMenuViewDTO.ImageUrl1, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                cateringMenu.ImageUrl1 = imgPath;
            }
            if (updateCateringMenuViewDTO.ImageUrl2 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + cateringMenu.ImageUrl2))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + cateringMenu.ImageUrl2);
                string imgPath = ImageHelper.CreateImage(updateCateringMenuViewDTO.ImageUrl2, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                cateringMenu.ImageUrl2 = imgPath;
            }
            if (updateCateringMenuViewDTO.ImageUrl3 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + cateringMenu.ImageUrl3))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + cateringMenu.ImageUrl3);
                string imgPath = ImageHelper.CreateImage(updateCateringMenuViewDTO.ImageUrl3, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                cateringMenu.ImageUrl3 = imgPath;
            }
            if (updateCateringMenuViewDTO.ImageUrl4 != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + cateringMenu.ImageUrl4))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + cateringMenu.ImageUrl4);
                string imgPath = ImageHelper.CreateImage(updateCateringMenuViewDTO.ImageUrl4, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                cateringMenu.ImageUrl4 = imgPath;
            }
            #endregion
            #region updateCateringMenuViewDTO
            cateringMenu.Title = updateCateringMenuViewDTO.Title;
            cateringMenu.ShortDescription = updateCateringMenuViewDTO.ShortDescription;
            cateringMenu.Description = updateCateringMenuViewDTO.Description;
            cateringMenu.CateringID = updateCateringMenuViewDTO.CateringID;
            cateringMenu.Price = updateCateringMenuViewDTO.Price;
            cateringMenu.Discount = Convert.ToDecimal(updateCateringMenuViewDTO.Discount);
            if (updateCateringMenuViewDTO.Discount == 0)
            {
                cateringMenu.DiscountPrice = 0;
            }
            else
            {
                cateringMenu.DiscountPrice = cateringMenu.Price - (cateringMenu.Price / cateringMenu.Discount);
            }
            cateringMenu.IsActive = updateCateringMenuViewDTO.IsActive;
            cateringMenu.LastDate = DateTime.Now;
            #endregion
            #region seo
            cateringMenu.seoDescription = updateCateringMenuViewDTO.seoDescription;
            cateringMenu.seoFacebookDescription = updateCateringMenuViewDTO.seoFacebookDescription;
            cateringMenu.seoFacebookKeywrods = updateCateringMenuViewDTO.seoFacebookKeywrods;
            cateringMenu.seoFacebookTitle = updateCateringMenuViewDTO.seoFacebookTitle;
            cateringMenu.seoFacebookUrl = updateCateringMenuViewDTO.seoFacebookUrl;
            cateringMenu.seoReply = updateCateringMenuViewDTO.seoReply;
            cateringMenu.seoTitle = updateCateringMenuViewDTO.seoTitle;
            cateringMenu.seoKeywords = updateCateringMenuViewDTO.seoKeywords;
            cateringMenu.seoTwitterDescription = updateCateringMenuViewDTO.seoTwitterDescription;
            cateringMenu.seoTwitterKeywords = updateCateringMenuViewDTO.seoTwitterKeywords;
            cateringMenu.seoTwitterTitle = updateCateringMenuViewDTO.seoTwitterTitle;
            cateringMenu.seoTwitterUrl = updateCateringMenuViewDTO.seoTwitterUrl;
            cateringMenu.seoDesign = "ImproBioTech and Infromation Technology";
            cateringMenu.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            cateringMenu.seoAuthor = "ImproBioTech and Information Technology";
            cateringMenu.seoSubject = "Restaurant";
            cateringMenu.Slug = StringHelper.StringReplacer(updateCateringMenuViewDTO.Title).ToLower();
            #endregion
            await unitOfWork.cateringMenuRepository.UpdateAsync(cateringMenu);
            await unitOfWork.SaveAsync();
            return Ok();

        }

        [Route("admin/catering-menu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.cateringMenuRepository.GetAsync(x => x.ID == id);
            if (fle == null)
                return NotFound();
            #region Image
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl1))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl1);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl2))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl2);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl3))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl3);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl4))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl4);
            #endregion
            await unitOfWork.cateringMenuRepository.DeleteAsync(fle);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
