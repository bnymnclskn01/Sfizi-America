using Mapster;
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


    public class ActionMailSettingController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMailSettingController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/mail-gonderim-ayarlari-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.mailSettingRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/mail-gonderim-ayarlari-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/mail-gonderim-ayarlari-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddMailSettingViewDTO addMailSettingViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            int countMailSetting = await unitOfWork.mailSettingRepository.CountAsync(x => x.IsActive == true);
            if (countMailSetting > 1)
                return BadRequest(new { errorMessage = "En fazla bir adet mail ayarı eklenebilir." });
            MailSetting mailSetting = addMailSettingViewDTO.Adapt<MailSetting>();
            await unitOfWork.mailSettingRepository.AddAsync(mailSetting);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/mail-gonderim-ayarlari-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var mailSetting = await unitOfWork.mailSettingRepository.GetAsync(x => x.ID == id);
            if (mailSetting == null)
                return NotFound();
            await unitOfWork.mailSettingRepository.DeleteAsync(mailSetting);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
