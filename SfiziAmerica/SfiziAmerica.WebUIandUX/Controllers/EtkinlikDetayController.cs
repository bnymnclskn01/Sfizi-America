using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.WebUIandUX.Models.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Controllers
{
    public class EtkinlikDetayController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public EtkinlikDetayController()
        {
            unitOfWork = new(context);
        }

        [Route("event/{SeoLink}")]
        public async Task<IActionResult> Index(string SeoLink)
        {
            var model = await unitOfWork.eventRepository.GetAsync(x => x.Slug == SeoLink);
            var list=await sfizilDatabase.Events.Where(x=>x.IsActive==true && x.Slug!=SeoLink).OrderBy(x=>x.CreateDate).ToListAsync();
            var about = await unitOfWork.aboutRepository.GetAsync(x => x.IsActive == true);
            var socialMedai = await unitOfWork.socialMediaRepository.GetAllAsync(x => x.IsActive == true);
            EventDetail eventDetail = new() { Event = model, Events = list, About = about, SocialMedias = socialMedai };
            return View(eventDetail);
        }
    }
}
