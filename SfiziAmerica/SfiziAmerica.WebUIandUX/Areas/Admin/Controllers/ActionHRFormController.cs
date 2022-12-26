using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionHRFormController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionHRFormController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/hr-formu-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.hrRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/hr-formu-detayi/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var appForm = await unitOfWork.hrRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            appForm.IsRead = true;
            appForm.LastDate = DateTime.Now;
            await unitOfWork.hrRepository.UpdateAsync(appForm);
            await unitOfWork.SaveAsync();
            return View(appForm);
        }

        [Route("admin/hr-formu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var appForm = await unitOfWork.hrRepository.GetAsync(x => x.ID == id);
            if (appForm == null)
                return NotFound();
            await unitOfWork.hrRepository.DeleteAsync(appForm);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
