using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
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
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            int countMailSetting = await unitOfWork.mailSettingRepository.CountAsync(x => x.IsActive == true);
            if (countMailSetting > 1)
                return BadRequest(new { errorMessage = "A maximum of one mail setting can be added." });
            MailSetting mailSetting = addMailSettingViewDTO.Adapt<MailSetting>();
            await unitOfWork.mailSettingRepository.AddAsync(mailSetting);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/mail-gonderim-ayarlari-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var mailSetting = await unitOfWork.mailSettingRepository.GetAsync(x => x.ID == id);
            if (mailSetting == null)
                return RedirectToAction("Index");
            updateMailSettingViewModel updateMailSettingViewModel = new() { MailSetting = mailSetting };
            return View(updateMailSettingViewModel);
        }

        [Route("admin/mail-gonderim-ayarlari-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMailSettingViewDTO updateMailSettingViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            var mailSetting = await unitOfWork.mailSettingRepository.GetAsync(x => x.ID == updateMailSettingViewDTO.ID);
            if (mailSetting == null)
                return NotFound(new { errorMessage = "There is no information for this record." });
            bool mailSettingExist = await unitOfWork.mailSettingRepository.AnyAsync(x => x.senderMail.ToLower() == updateMailSettingViewDTO.senderMail.ToLower() && x.ID != updateMailSettingViewDTO.ID);
            if (mailSettingExist)
                return BadRequest(new { errorMessage = "A record with this name already exists" });
            mailSetting.senderMail = updateMailSettingViewDTO.senderMail;
            mailSetting.serverMail= updateMailSettingViewDTO.serverMail;
            mailSetting.senderMailPassword= updateMailSettingViewDTO.senderMailPassword;
            mailSetting.serverPort= updateMailSettingViewDTO.serverPort;
            mailSetting.LastDate= DateTime.Now;
            mailSetting.BCC= updateMailSettingViewDTO.BCC;
            mailSetting.To= updateMailSettingViewDTO.To;
            mailSetting.CC= updateMailSettingViewDTO.CC;
            mailSetting.ID= updateMailSettingViewDTO.ID;
            await unitOfWork.mailSettingRepository.UpdateAsync(mailSetting);
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
