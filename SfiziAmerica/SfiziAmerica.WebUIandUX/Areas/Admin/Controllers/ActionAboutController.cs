using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.Helper;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionAboutController : Controller
    {
        DbContext context = new SfizilDatabaseModelContext();
        UnitOfWork unitOfWork;
        public ActionAboutController()
        {
            unitOfWork = new(context);
        }
        [Route("admin/hakkimizda-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.aboutRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/hakkimizda-ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/hakkimizda-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddAboutDTO addAboutDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            bool aboutExist = await unitOfWork.aboutRepository.AnyAsync(x => x.Title.ToLower() == addAboutDTO.Title.ToLower());
            if (aboutExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            About about = addAboutDTO.Adapt<About>();
            if (addAboutDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addAboutDTO.ImageUrl, "About");
                if (imgPath == string.Empty)
                    return BadRequest();
                about.ImageUrl = imgPath;
            }
            await unitOfWork.aboutRepository.AddAsync(about);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
