using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionCateringController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionCateringController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/catering-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.cateringRepository.GetAllAsync(null, x => x.ParentCategory);
            return View(model);
        }
    }
}
