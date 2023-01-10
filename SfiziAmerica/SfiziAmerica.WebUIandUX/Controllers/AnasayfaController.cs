using Microsoft.AspNetCore.Mvc;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class AnasayfaController : Controller
    {
        [Route("")]
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
