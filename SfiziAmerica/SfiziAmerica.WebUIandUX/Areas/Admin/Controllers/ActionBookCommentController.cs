using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.Helper;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionBookCommentController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionBookCommentController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/musteri-yorumlari-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.bookCommentRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/musteri-yorumlari-detay/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var bookComment = await unitOfWork.bookCommentRepository.GetAsync(x => x.ID == id);
            if (bookComment == null)
                return RedirectToAction("Index");
            updateBookCommentViewModel updateBookCommentViewModel = new() { BookComment = bookComment };
            return View(updateBookCommentViewModel);
        }

        [Route("admin/musteri-yorumlari-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var bookComment = await unitOfWork.bookCommentRepository.GetAsync(x => x.ID == id);
            if (bookComment == null)
                return RedirectToAction("Index");
            updateBookCommentViewModel updateBookCommentViewModel = new() { BookComment= bookComment };
            return View(updateBookCommentViewModel);
        }


        [Route("admin/musteri-yorumlari-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(updateBookCommentViewDTO updateBookCommentViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            var bookComment = await unitOfWork.bookCommentRepository.GetAsync(x => x.ID == updateBookCommentViewDTO.ID);
            if (bookComment == null)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            bookComment.NameSurname = updateBookCommentViewDTO.NameSurname;
            bookComment.Email = updateBookCommentViewDTO.Email;
            bookComment.Message= updateBookCommentViewDTO.Message;
            bookComment.LastDate = DateTime.Now;
            bookComment.Phone = updateBookCommentViewDTO.Phone;
            bookComment.IsActive = updateBookCommentViewDTO.IsActive;
            await unitOfWork.bookCommentRepository.UpdateAsync(bookComment);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/musteri-yorumlari-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await unitOfWork.bookCommentRepository.GetAsync(x => x.ID == id);
            if (model == null)
            {
                return NotFound();
            }
            if (System.IO.File.Exists("wwwroot/Image/BookComment/" + model.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/BookComment/" + model.ImageUrl);
            await unitOfWork.bookCommentRepository.DeleteAsync(model);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
