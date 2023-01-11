using Microsoft.AspNetCore.Mvc;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
