using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class HakkimizdaController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public HakkimizdaController()
        {
            unitOfWork = new(context);
        }

        [Route("about")]
        public async Task<IActionResult> Index()
        {
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.IsActive == true);
            return View(about);
        }
    }
}
