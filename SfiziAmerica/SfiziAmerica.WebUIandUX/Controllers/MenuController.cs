using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class MenuController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public MenuController()
        {
            unitOfWork = new(context);
        }

        [Route("menu")]
        public async Task<IActionResult> Index()
        {
            var menuCategory = await sfizilDatabase.MenuCategories.Where(x => x.IsActive == true).OrderBy(x => x.Rank).Include(x => x.CategoryMenus).ThenInclude(x => x.Menu).ToListAsync();
            return View(menuCategory);
        }
    }
}
