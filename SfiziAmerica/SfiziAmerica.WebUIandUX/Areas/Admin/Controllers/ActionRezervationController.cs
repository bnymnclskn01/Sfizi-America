using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Concrete;
using SfiziAmerica.DataAccessLayer.ModelContext;
using SfiziAmerica.EntityLayer.Model;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO;
using SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel;
using System;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActionRezervationController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionRezervationController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/rezervasyon-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.rezervationRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/rezervasyon-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/rezervasyon-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddRezervationViewDTO addRezervationViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool rezervationExist = await unitOfWork.rezervationRepository.AnyAsync(x => x.NameSurname.ToLower() == addRezervationViewDTO.NameSurname.ToLower() && x.Date.ToLower() == addRezervationViewDTO.Date.ToLower() && x.Time.ToLower() == addRezervationViewDTO.Time.ToLower());
            if (rezervationExist)
                return BadRequest(new { errorMessage = "Since there is a reservation for this record, we cannot add it again." });
            Rezervation rezervation = addRezervationViewDTO.Adapt<Rezervation>();
            await unitOfWork.rezervationRepository.AddAsync(rezervation);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/rezervasyon-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var rezervation = await unitOfWork.rezervationRepository.GetAsync(x => x.ID == id);
            if (rezervation == null)
                return RedirectToAction("Index");
            updateRezervationViewModel updateRezervationViewModel = new() { Rezervation = rezervation };
            return View(updateRezervationViewModel);
        }

        [Route("admin/rezervasyon-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateRezervationViewDTO updateRezervationViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            var rezervation = await unitOfWork.rezervationRepository.GetAsync(x => x.ID == updateRezervationViewDTO.ID);
            if (rezervation == null)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            bool rezervationExist = await unitOfWork.rezervationRepository.AnyAsync(x => x.NameSurname.ToLower() == updateRezervationViewDTO.NameSurname.ToLower() && x.Date.ToLower() == updateRezervationViewDTO.Date.ToLower() && x.Time.ToLower() == updateRezervationViewDTO.Time.ToLower() && x.ID != updateRezervationViewDTO.ID);
            if (rezervationExist)
                return BadRequest(new { errorMessage = "Since there is a reservation for this record, we cannot add it again." });
            rezervation.Message = updateRezervationViewDTO.Message;
            rezervation.LastDate = DateTime.Now;
            rezervation.Date = updateRezervationViewDTO.Date;
            rezervation.Email= updateRezervationViewDTO.Email;
            rezervation.IsActive = updateRezervationViewDTO.IsActive;
            rezervation.NameSurname = updateRezervationViewDTO.NameSurname;
            rezervation.Person = Convert.ToInt32(updateRezervationViewDTO.Person);
            rezervation.Phone = updateRezervationViewDTO.Phone;
            rezervation.TableType= updateRezervationViewDTO.TableType;
            rezervation.Time= updateRezervationViewDTO.Time;
            await unitOfWork.rezervationRepository.UpdateAsync(rezervation);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/rezervasyon-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await unitOfWork.rezervationRepository.GetAsync(x => x.ID == id);
            if (model == null)
            {
                return NotFound();
            }
            await unitOfWork.rezervationRepository.DeleteAsync(model);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
