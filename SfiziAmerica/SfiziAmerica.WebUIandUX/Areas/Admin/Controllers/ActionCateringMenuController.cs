using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionCateringMenuController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionCateringMenuController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/catering-menu-Listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.cateringMenuRepository.GetAllAsync(null, x => x.Catering);
            return View(model);
        }

        [Route("admin/catering-menu-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var CateringList = await unitOfWork.cateringRepository.GetAllAsync();
            return View();
        }

        [Route("admin/catering-menu-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddCateringMenuViewDTO addCateringMenuViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool cateringMenuExist = await unitOfWork.cateringMenuRepository.AnyAsync(x => x.Title.ToLower() == addCateringMenuViewDTO.Title.ToLower());
            if (cateringMenuExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            CateringMenu cateringMenu = addCateringMenuViewDTO.Adapt<CateringMenu>();
            return Ok();
        }

        [Route("admin/catering-menu-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.cateringMenuRepository.GetAsync(x => x.ID == id);
            if (fle == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl1))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl1);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl2))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl2);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl3))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl3);
            if (System.IO.File.Exists("wwwroot/Image/Catering/" + fle.ImageUrl4))
                System.IO.File.Delete("wwwroot/Image/Catering/" + fle.ImageUrl4);
            await unitOfWork.cateringMenuRepository.DeleteAsync(fle);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
