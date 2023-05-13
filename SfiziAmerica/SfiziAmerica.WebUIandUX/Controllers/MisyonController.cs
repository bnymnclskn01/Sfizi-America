using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class MisyonController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public MisyonController()
        {
            unitOfWork = new(context);
        }

        [Route("mission")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Seo = await unitOfWork.menuSeoRepository
                .GetAsync(x => x.IsActive == true && x.PageName == "Mission");
            var mission = await unitOfWork.missionRepository.GetAsync(x => x.IsActive == true);
            return View(mission);
        }
    }
}
