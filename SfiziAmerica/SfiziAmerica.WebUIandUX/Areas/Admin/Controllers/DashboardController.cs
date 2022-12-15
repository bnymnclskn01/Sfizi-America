using Microsoft.AspNetCore.Mvc;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        [Route("admin/gosterge-paneli")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
