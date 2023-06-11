using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class IletisimController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IletisimController()
        {
            unitOfWork = new(context);
        }
        [Route("contact")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Seo = await unitOfWork.menuSeoRepository.GetAsync(x => x.IsActive == true && x.PageName == "Contact");
            ViewBag.contactInformation = await unitOfWork
                .contactInformationRepository
                .GetAsync(x => x.IsActive == true);
            ViewBag.socialMedia = await unitOfWork
                .socialMediaRepository
                .GetAllAsync(x => x.IsActive == true);
            return View();
        }
        [Route("contact")]
        [HttpPost]
        public async Task<IActionResult> Index(ContactForm contactForm)
        {
            var captchaImage = HttpContext.Request.Form["g-recaptcha-response"];
            var verified = await CheckCaptcha();
            var smtp = await unitOfWork.mailSettingRepository.GetAsync(x => x.IsActive == true);
            try
            {
                if (string.IsNullOrEmpty(captchaImage))
                {
                    ViewBag.Hata = "Your transaction failed.";
                    return View(contactForm);
                }
                if (!verified)
                {
                    ViewBag.Hata = "Your transaction failed.";
                    return View(contactForm);
                }
                if (ModelState.IsValid)
                {
                    contactForm.CreateDate = DateTime.Now;
                    contactForm.LastDate = DateTime.Now;
                    contactForm.IsRead = false;
                    await unitOfWork.contactFormRepository.AddAsync(contactForm);
                    await unitOfWork.SaveAsync();
                    ViewBag.Mesaj = "Your e-mail has reached us and we will get back to you as soon as possible.";
                }
                else
                {
                    ViewBag.Mesaj = "We encountered a systemic error while sending data to the model, and we will continue to serve you by solving it as soon as possible.";
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            ViewBag.Seo = await unitOfWork.menuSeoRepository.GetAsync(x => x.IsActive == true && x.PageName == "Contact");
            ViewBag.contactInformation = await unitOfWork
                .contactInformationRepository
                .GetAllAsync(x => x.IsActive == true);
            ViewBag.socialMedia = await unitOfWork
                .socialMediaRepository
                .GetAllAsync(x => x.IsActive == true);
            return View(contactForm);
        }
        #region Google Captcha
        private async Task<bool> CheckCaptcha()
        {
            var postData = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("secret", "6Ldm9uciAAAAAO3lhEk4ZcxkXOiilDvzHf086GQv"),
                new KeyValuePair<string, string>("response", HttpContext.Request.Form["g-recaptcha-response"])
            };

            var client = new HttpClient();
            var response = await client.PostAsync("https://www.google.com/recaptcha/api/siteverify", new FormUrlEncodedContent(postData));

            var o = (JObject)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());

            return (bool)o["success"];
        }
        #endregion
    }
}
