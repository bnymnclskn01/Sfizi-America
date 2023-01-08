using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionMenuCategoryController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMenuCategoryController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/menü-kategori-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.menuCategoryRepository.GetAllAsync(null,x=>x.ParentMenuCategory);
            return View(model);
        }


        [Route("admin/menü-kategori-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fle = await unitOfWork.menuCategoryRepository.GetAsync(x => x.ID == id);
            var model = await unitOfWork.menuCategoryRepository.GetAllAsync(x => x.MenuCategoryID == fle.ID);
            if (fle == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl1))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl1);
            if (System.IO.File.Exists("wwwroot/Image/Menu/" + fle.ImageUrl2))
                System.IO.File.Delete("wwwroot/Image/Menu/" + fle.ImageUrl2);
            await unitOfWork.menuCategoryRepository.DeleteAsync(fle);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
