using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class KatringController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public KatringController()
        {
            unitOfWork = new(context);
        }

        [Route("catering")]
        public async Task<IActionResult> Index()
        {
            var model = await sfizilDatabase.Caterings.Where(x => x.IsActive == true).Include(x=>x.ParentCategory).Include(x=>x.CateringMenus).OrderBy(x=>x.Rank).ToListAsync();
            return View(model);
        }
    }
}
