using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class BasvuruFormController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public BasvuruFormController()
        {
            unitOfWork = new(context);
        }

        [Route("application-form")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contactInformation = await unitOfWork
                .contactInformationRepository
                .GetAllAsync(x => x.IsActive == true);
            var socialMedia = await unitOfWork
                .socialMediaRepository
                .GetAllAsync(x => x.IsActive == true);
            var caterings = await unitOfWork.cateringRepository.GetAllAsync(x => x.IsActive == true, x => x.ParentCategory);
            ApplicationViewModel applicationViewModel = new() { ContactInformations = contactInformation, SocialMedias = socialMedia, Caterings = caterings };
            return View(applicationViewModel);
        }
    }
}
