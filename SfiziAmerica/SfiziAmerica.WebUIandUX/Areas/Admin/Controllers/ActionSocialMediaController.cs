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
            bool aboutExist = await unitOfWork.socialMediaRepository.AnyAsync(x => x.Title.ToLower() == socialMedia.Title.ToLower());
            if (aboutExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            await unitOfWork.socialMediaRepository.AddAsync(socialMedia);
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
