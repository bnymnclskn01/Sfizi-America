using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class RezervasyonController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public RezervasyonController()
        {
            unitOfWork = new(context);
        }
        [Route("reservation")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Seo = await unitOfWork.menuSeoRepository
                .GetAsync(x => x.IsActive == true && x.PageName == "Rezervation");
            var contactInformation = await unitOfWork
                           .contactInformationRepository
                           .GetAllAsync(x => x.IsActive == true);
            var socialMedia = await unitOfWork
                .socialMediaRepository
                .GetAllAsync(x => x.IsActive == true);
            ContactViewModel contactViewModel = new() { ContactInformations = contactInformation, SocialMedias = socialMedia };
            return View(contactViewModel);
        }
    }
}
