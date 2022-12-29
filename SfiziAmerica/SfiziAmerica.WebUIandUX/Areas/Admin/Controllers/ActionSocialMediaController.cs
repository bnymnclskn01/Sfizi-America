using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionSocialMediaController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionSocialMediaController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/sosyal-medya-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.socialMediaRepository.GetAllAsync();
            return View(model);
        }

        [HttpGet("admin/sosyal-medya-ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("admin/sosyal-medya-ekle")]
        public async Task<IActionResult> Create(SocialMedia socialMedia)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            bool socialMediaExist = await unitOfWork.socialMediaRepository.AnyAsync(x => x.Title.ToLower() == socialMedia.Title.ToLower());
            if (socialMediaExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            await unitOfWork.socialMediaRepository.AddAsync(socialMedia);
            await unitOfWork.SaveAsync();
            return Ok();
        }
        [Route("admin/sosyal-medya-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var socialMedia = await unitOfWork.socialMediaRepository.GetAsync(x => x.ID == id);
            if (socialMedia == null)
                return RedirectToAction("Index");
            return View(socialMedia);
        }

        [Route("admin/sosyal-medya-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(SocialMedia socialMediaModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            var socialMedia = await unitOfWork.socialMediaRepository.GetAsync(x => x.ID == socialMediaModel.ID);

            if (socialMedia == null)
                return NotFound(new { errorMessage = "Bu kayıta ait bilgi bulunmamaktadır" });
            bool socialMediaExist = await unitOfWork.socialMediaRepository.AnyAsync(x => x.Title.ToLower() == socialMedia.Title.ToLower() && x.ID != socialMedia.ID);
            if (socialMediaExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            socialMedia.Title = socialMediaModel.Title;
            socialMedia.Icon = socialMediaModel.Icon;
            socialMedia.Url = socialMediaModel.Url;
            socialMedia.IsActive = socialMediaModel.IsActive;
            socialMedia.LastDate = DateTime.Now;
            await unitOfWork.socialMediaRepository.UpdateAsync(socialMedia);
            await unitOfWork.SaveAsync();
            return Ok();
        }


        [Route("admin/sosyal-medya-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var socialMedia = await unitOfWork.socialMediaRepository.GetAsync(x => x.ID == id);
            if (socialMedia == null)
                return NotFound();
            await unitOfWork.socialMediaRepository.DeleteAsync(socialMedia);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
