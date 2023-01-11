using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class AnasayfaController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase=new SfizilDatabaseModelContext();
        public AnasayfaController()
        {
            unitOfWork = new(context);
        }
        [Route("")]
        [Route("home")]
        public async Task<IActionResult> Index()
        {
            var sliders = await sfizilDatabase.Sliders.Where(x => x.IsActive == true).OrderBy(x => x.Rank).ToListAsync();
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.IsActive == true);
            var contactInformation = await unitOfWork.contactInformationRepository.GetAsync(x => x.IsActive == true);
            var events=await sfizilDatabase.Events.Where(x=>x.IsActive==true).OrderByDescending(x=>x.ID).ToListAsync();
            var socialMedia = await unitOfWork.socialMediaRepository.GetAllAsync(x => x.IsActive == true);
            var menuCategory = await sfizilDatabase.MenuCategories.Where(x => x.IsActive == true).OrderBy(x => x.Rank).Include(x => x.CategoryMenus).ThenInclude(x => x.Menu).ToListAsync();
            var caterings = await sfizilDatabase.Caterings.Where(x => x.IsActive == true).OrderBy(x => x.Rank).ToListAsync();
            var customerComment = await sfizilDatabase.BookComments.Where(x => x.IsActive == true).OrderByDescending(x => x.ID).ToListAsync();
            AnasayfaViewModel anasayfaViewModel = new() { About = about, Sliders = sliders, ContactInformation = contactInformation, Events = events, MenuCategories = menuCategory, SocialMedias = socialMedia, Caterings = caterings, BookComments = customerComment };
            return View(anasayfaViewModel);
        }
    }
}
