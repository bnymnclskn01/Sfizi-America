using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionMissionController : Controller
    {
        DbContext context = new SfizilDatabaseModelContext();
        UnitOfWork unitOfWork;
        public ActionMissionController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/misyon-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.missionRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/misyon-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var misyon = await unitOfWork.missionRepository.GetAsync(x => x.ID == id);
            if (misyon == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Mission/" + misyon.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/Mission/" + misyon.ImageUrl);
            await unitOfWork.missionRepository.DeleteAsync(misyon);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
