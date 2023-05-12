using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionLogoController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionLogoController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/logo-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.logoRepository.GetAllAsync();
            return View(model);
        }
    }
}
