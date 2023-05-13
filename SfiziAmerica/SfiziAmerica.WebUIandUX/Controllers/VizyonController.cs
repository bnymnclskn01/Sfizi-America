using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class VizyonController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public VizyonController()
        {
            unitOfWork = new(context);
        }
        [Route("vision")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Seo = await unitOfWork.menuSeoRepository
                .GetAsync(x => x.IsActive == true && x.PageName == "Vision");
            var vision = await unitOfWork.visionRepository.GetAsync(x => x.IsActive == true);
            return View(vision);
        }
    }
}
