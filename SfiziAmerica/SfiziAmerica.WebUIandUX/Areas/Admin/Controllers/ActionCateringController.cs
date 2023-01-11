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
    public class ActionCateringController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionCateringController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/catering-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.cateringRepository.GetAllAsync(null, x => x.ParentCategory);
            return View(model);
        }

        [Route("admin/catering-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var parentCateringList = await unitOfWork.cateringRepository.GetAllAsync();
            return View(parentCateringList);
        }

        [Route("admin/catering-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddCateringViewDTO addCateringViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool cateringExist = await unitOfWork.cateringRepository.AnyAsync(x => x.Title.ToLower() == addCateringViewDTO.Title.ToLower());
            if (cateringExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            int cateringCount = await unitOfWork.cateringRepository.CountAsync(x => x.IsMainActive == true);
            if (cateringCount > 3)
                return BadRequest(new { errorMessage = "The maximum number of catering that will appear on the main page should be 3." });
            Catering catering = addCateringViewDTO.Adapt<Catering>();
            if (addCateringViewDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addCateringViewDTO.ImageUrl, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest();
                catering.ImageUrl = imgPath;
            }
            catering.seoDesign = "ImproBioTech and Infromation Technology";
            catering.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            catering.seoAuthor = "ImproBioTech and Information Technology";
            catering.seoSubject = "Restaurant";
            catering.Slug = StringHelper.StringReplacer(addCateringViewDTO.Title).ToLower();
            await unitOfWork.cateringRepository.AddAsync(catering);
            await unitOfWork.SaveAsync();
            return Ok();
        }


        [Route("admin/catering-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var catering = await unitOfWork.cateringRepository.GetAsync(x => x.ID == id, x => x.ParentCategory);
            if (catering == null)
                return RedirectToAction("Index");
            var parentCateringList = await unitOfWork.cateringRepository.GetAllAsync();
            updateCateringViewModel updateCateringViewModel = new() { Catering = catering, Caterings = parentCateringList };
            return View(updateCateringViewModel);
        }

        [Route("admin/catering-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCateringViewDTO updateCateringViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });

            bool cateringExist = await unitOfWork.cateringRepository.AnyAsync(x => x.Title.ToLower() == updateCateringViewDTO.Title.ToLower() && x.ID != updateCateringViewDTO.ID);
            var catering = await unitOfWork.cateringRepository.GetAsync(x => x.ID == updateCateringViewDTO.ID);
            if (catering == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            if (cateringExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            int cateringCount = await unitOfWork.cateringRepository.CountAsync(x => x.IsMainActive == true);
            if (cateringCount > 3)
                return BadRequest(new { errorMessage = "The maximum number of catering that will appear on the main page should be 3." });
            if (updateCateringViewDTO.ImageUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + catering.ImageUrl))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + catering.ImageUrl);
                string imgPath = ImageHelper.CreateImage(updateCateringViewDTO.ImageUrl, "Catering");
                if (imgPath == string.Empty)
                    return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
                catering.ImageUrl = imgPath;
            }
            catering.Rank = updateCateringViewDTO.Rank;
            catering.Title = updateCateringViewDTO.Title;
            catering.ShortDescription = updateCateringViewDTO.ShortDescription;
            catering.Description = updateCateringViewDTO.Description;
            catering.parentCateringID = updateCateringViewDTO.parentCateringID;

            catering.IsActive = updateCateringViewDTO.IsActive;
            catering.IsMainActive = updateCateringViewDTO.IsMainActive;
            catering.LastDate = DateTime.Now;

            #region seo
            catering.seoDescription = updateCateringViewDTO.seoDescription;
            catering.seoFacebookDescription = updateCateringViewDTO.seoFacebookDescription;
            catering.seoFacebookKeywrods = updateCateringViewDTO.seoFacebookKeywrods;
            catering.seoFacebookTitle = updateCateringViewDTO.seoFacebookTitle;
            catering.seoFacebookUrl = updateCateringViewDTO.seoFacebookUrl;
            catering.seoReply = updateCateringViewDTO.seoReply;
            catering.seoTitle = updateCateringViewDTO.seoTitle;
            catering.seoKeywords = updateCateringViewDTO.seoKeywords;
            catering.seoTwitterDescription = updateCateringViewDTO.seoTwitterDescription;
            catering.seoTwitterKeywords = updateCateringViewDTO.seoTwitterKeywords;
            catering.seoTwitterTitle = updateCateringViewDTO.seoTwitterTitle;
            catering.seoTwitterUrl = updateCateringViewDTO.seoTwitterUrl;
            catering.seoDesign = "ImproBioTech and Infromation Technology";
            catering.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            catering.seoAuthor = "ImproBioTech and Information Technology";
            catering.seoSubject = "Restaurant";
            catering.Slug = StringHelper.StringReplacer(updateCateringViewDTO.Title).ToLower();
            #endregion

            await unitOfWork.cateringRepository.UpdateAsync(catering);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/catering-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.cateringRepository.GetAsync(x => x.ID == id);
            var model = await unitOfWork.cateringMenuRepository.GetAllAsync(x => x.CateringID == fle.ID);
            if (fle == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl);
            await unitOfWork.cateringRepository.DeleteAsync(fle);
            foreach (var item in model)
            {
                #region Image
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + item.ImageUrl1))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + item.ImageUrl1);
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + item.ImageUrl2))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + item.ImageUrl2);
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + item.ImageUrl3))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + item.ImageUrl3);
                if (System.IO.File.Exists("wwwroot/Image/Catering/" + item.ImageUrl4))
                    System.IO.File.Delete("wwwroot/Image/Catering/" + item.ImageUrl4);
                #endregion
                await unitOfWork.cateringMenuRepository.DeleteAsync(item);
                await unitOfWork.SaveAsync();
            }
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
