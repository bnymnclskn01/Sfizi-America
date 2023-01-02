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
    public class ActionContactInformationController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionContactInformationController()
        {
            unitOfWork = new(context);
        }


        [Route("admin/iletisim-bilgileri-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.contactInformationRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/iletisim-bilgisi-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Route("admin/iletisim-bilgisi-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddContactInformationViewDTO addContactInformationViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool ciExist = await unitOfWork.contactInformationRepository.AnyAsync(x => x.Address.ToLower() == addContactInformationViewDTO.Address.ToLower() && x.Phone == addContactInformationViewDTO.Phone);
            if (ciExist)
                return BadRequest(new { errorMessage = "Since there is a reservation for this record, we cannot add it again." });
            ContactInformation contactInformation = addContactInformationViewDTO.Adapt<ContactInformation>();
            await unitOfWork.contactInformationRepository.AddAsync(contactInformation);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [HttpGet, Route("admin/iletisim-bilgisi-guncelle/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await unitOfWork.contactInformationRepository.GetAsync(x => x.ID == id);
            if (model == null)
                return RedirectToAction("Index");
            return View(model);
        }

        [HttpPost, Route("admin/iletisim-bilgisi-guncelle")]
        public async Task<IActionResult> Edit(UpdateContactInformationViewDTO updateContactInformationViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            var cid = await unitOfWork.contactInformationRepository.GetAsync(x => x.ID == updateContactInformationViewDTO.ID);
            if (cid == null)
                return NotFound(new { errorMessage = "There is no information for this record" });
            bool cidExist = await unitOfWork.contactInformationRepository.AnyAsync(x => x.Address.ToLower() == updateContactInformationViewDTO.Address.ToLower() && x.Phone == updateContactInformationViewDTO.Phone && x.ID != updateContactInformationViewDTO.ID);
            if (cidExist)
                return BadRequest(new { errorMessage = "Since there is a reservation for this record, we cannot add it again." });
            cid.WhatsApp = updateContactInformationViewDTO.WhatsApp;
            cid.Address = updateContactInformationViewDTO.Address;
            cid.Address2 = updateContactInformationViewDTO.Address2;
            cid.Address3 = updateContactInformationViewDTO.Address3;
            cid.Address4 = updateContactInformationViewDTO.Address4;
            cid.Email = updateContactInformationViewDTO.Email;
            cid.Email2 = updateContactInformationViewDTO.Email2;
            cid.Email3 = updateContactInformationViewDTO.Email3;
            cid.Email4 = updateContactInformationViewDTO.Email4;
            cid.Phone = updateContactInformationViewDTO.Phone;
            cid.Phone2 = updateContactInformationViewDTO.Phone2;
            cid.Phone3 = updateContactInformationViewDTO.Phone3;
            cid.Phone4 = updateContactInformationViewDTO.Phone4;
            cid.ID = updateContactInformationViewDTO.ID;
            cid.IsActive = updateContactInformationViewDTO.IsActive;
            cid.LastDate = DateTime.Now;
            await unitOfWork.contactInformationRepository.UpdateAsync(cid);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [HttpPost("admin/iletisim-bilgisi-sil/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await unitOfWork.contactInformationRepository.GetAsync(x => x.ID == id);
            if (model == null)
            {
                return NotFound();
            }
            await unitOfWork.contactInformationRepository.DeleteAsync(model);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
