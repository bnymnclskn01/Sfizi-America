using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionRezervationController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionRezervationController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/rezervasyon-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.rezervationRepository.GetAllAsync();
            return View(model);
        }
    }
}
