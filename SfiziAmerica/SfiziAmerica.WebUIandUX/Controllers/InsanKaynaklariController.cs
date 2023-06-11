using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class InsanKaynaklariController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public InsanKaynaklariController()
        {
            unitOfWork = new(context);
        }
        [Route("human-resources")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Seo = await unitOfWork.menuSeoRepository.GetAsync(x => x.IsActive == true && x.PageName == "Human Resources");
            return View();
        }

        [Route("human-resources")]
        [HttpPost]
        public async Task<IActionResult> Index(HR hrForm, IFormFile Resume)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Resume != null)
                    {
                        var extension = Path.GetExtension(Resume.FileName).Trim('.').ToLower();
                        if (!(new[] { "pdf", "PDF" }.Contains(extension)))
                        {
                            ViewBag.Hata = "Files in pdf format with incorrect file extension are accepted.";
                        }
                        var url_path = Guid.NewGuid().ToString() + Resume.FileName;
                        var local_image_dir = $"wwwroot/Pdf/Resume/";
                        var local_image_path = $"{local_image_dir}/{url_path}";
                        if (!Directory.Exists(Path.Combine(local_image_dir)))
                            Directory.CreateDirectory(Path.Combine(local_image_dir));
                        using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
                        {
                            Resume.CopyTo(fileStream);
                        }
                        hrForm.Resume = $"{url_path}";
                    }
                    hrForm.CreateDate = DateTime.Now;
                    hrForm.LastDate = DateTime.Now;
                    hrForm.IsRead = false;
                    await unitOfWork.hrRepository.AddAsync(hrForm);
                    await unitOfWork.SaveAsync();
                    ViewBag.Mesaj = "Your e-mail has reached us and we will get back to you as soon as possible.";
                }
            }
            catch
            {
                ViewBag.Hata = "We are unable to process due to a system failure. Please try again later.";
            }
            ViewBag.Seo = await unitOfWork.menuSeoRepository.GetAsync(x => x.IsActive == true && x.PageName == "Human Resources");
            return View(hrForm);
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
