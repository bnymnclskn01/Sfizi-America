using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionContactFormController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionContactFormController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/iletisim-formu-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.contactFormRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/iletisim-formu-detayi/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var appForm = await unitOfWork.contactFormRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            appForm.IsRead = true;
            appForm.LastDate = DateTime.Now;
            await unitOfWork.contactFormRepository.UpdateAsync(appForm);
            await unitOfWork.SaveAsync();
            return View(appForm);
        }

        [Route("admin/iletisim-formu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var appForm = await unitOfWork.contactFormRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            await unitOfWork.contactFormRepository.DeleteAsync(appForm);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
