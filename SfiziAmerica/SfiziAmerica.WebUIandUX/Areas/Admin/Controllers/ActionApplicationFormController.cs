using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionApplicationFormController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionApplicationFormController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/basvuru-formu-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.applicationFormRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/basvuru-formu-detayi/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var appForm = await unitOfWork.applicationFormRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            appForm.IsRead = true;
            appForm.LastDate = DateTime.Now;
            await unitOfWork.applicationFormRepository.UpdateAsync(appForm);
            await unitOfWork.SaveAsync();
            return View(appForm);
        }

        [Route("admin/basvuru-formu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var appForm = await unitOfWork.applicationFormRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            await unitOfWork.applicationFormRepository.DeleteAsync(appForm);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
