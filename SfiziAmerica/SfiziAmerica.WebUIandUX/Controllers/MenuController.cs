using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
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

        [Route("menu/{Slug}")]
        public async Task<IActionResult> Index(string Slug)
        {
            ViewBag.Seo = await unitOfWork.menuCategoryRepository.GetAsync(x => x.Slug == Slug);
            var menuFirst = await sfizilDatabase
                .MenuCategories
                .Where(x => x.Slug == Slug)
                .FirstOrDefaultAsync();
            var menuList = await sfizilDatabase
                .MenuCategories
                .Include(x => x.ParentMenuCategory)
                .Include(x => x.CategoryMenus)
                .ThenInclude(x => x.Menu)
                .ToListAsync();
            PageMenuModel pageMenuModel = new()
            {
                MenuCategory = menuFirst,
                MenuCategories = menuList
            };
            return View(pageMenuModel);
        }
    }
}
