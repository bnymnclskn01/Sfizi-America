using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionLoginController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionLoginController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/giris-yap")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("admin/giris-yap")]
        [HttpPost]
        public async Task<IActionResult> Index(string Email, string Password)
        {
            var admin = await unitOfWork.userMemberRepository
           .GetAllAsync(x => x.Email.ToLower() == Email.ToLower() && x.Password == Password, x => x.UserRole);
            var user = admin.FirstOrDefault();
            if (admin.Count == 0)
                return NotFound(new { errorMessage = "The email address and or password you entered is incorrect. Check your information." });
            HttpContext.Session.SetString("ID", user.ID.ToString());
            HttpContext.Session.SetString("Email", user.Email);
            HttpContext.Session.SetString("Password", user.Password);
            HttpContext.Session.SetString("NameSurname", user.NameSurname);
            HttpContext.Session.SetString("UserRoleID", user.UserRoleID.ToString());
            HttpContext.Session.SetString("UserRoleName", user.UserRole.RoleName);
            HttpContext.Session.SetString("Phone", user.Phone);
            return Ok();
        }
        [Route("admin/cikis-yap")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
