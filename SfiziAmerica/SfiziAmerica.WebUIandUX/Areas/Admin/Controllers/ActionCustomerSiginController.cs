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
    public class ActionCustomerSiginController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionCustomerSiginController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/musteri-kayit-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.customerSiginRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/musteri-kayit-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/musteri-kayit-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddCustomerSiginViewDTO addCustomerSiginViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });

            bool userMemberExist = await unitOfWork.customerSiginRepository.AnyAsync(x => x.Email.ToLower() == addCustomerSiginViewDTO.Email.ToLower());

            if (userMemberExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            CustomerSigin customerSigin = addCustomerSiginViewDTO.Adapt<CustomerSigin>();
            await unitOfWork.customerSiginRepository.AddAsync(customerSigin);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/musteri-kayit-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var customerSigin = await unitOfWork.customerSiginRepository.GetAsync(x => x.ID == id);
            if (customerSigin == null)
                return RedirectToAction("Index");
            updateCustomerSiginViewModel updateCustomerSiginViewModel = new() { CustomerSigin= customerSigin };
            return View(updateCustomerSiginViewModel);
        }

        [Route("admin/musteri-kayit-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCustomerSiginViewDTO updateCustomerSiginViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });

            var customerSigin = await unitOfWork.customerSiginRepository.GetAsync(x => x.ID == updateCustomerSiginViewDTO.ID);

            if (customerSigin == null)
                return NotFound(new { errorMessage = "There is no information about this record." });

            bool customerSiginExist = await unitOfWork.customerSiginRepository
                .AnyAsync(x => x.Email.ToLower() == updateCustomerSiginViewDTO.Email.ToLower() && x.ID != updateCustomerSiginViewDTO.ID);

            if (customerSiginExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            customerSigin.Email= updateCustomerSiginViewDTO.Email;
            customerSigin.LastDate = DateTime.Now;
            customerSigin.IsActive = updateCustomerSiginViewDTO.IsActive;
            customerSigin.NameSurname = updateCustomerSiginViewDTO.NameSurname;
            customerSigin.Password= updateCustomerSiginViewDTO.Password;
            customerSigin.Phone=updateCustomerSiginViewDTO.Phone;
            await unitOfWork.customerSiginRepository.UpdateAsync(customerSigin);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/musteri-kayit-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customerSigin = await unitOfWork.customerSiginRepository.GetAsync(x => x.ID == id);
            if (customerSigin == null)
            {
                return NotFound();
            }
            await unitOfWork.customerSiginRepository.DeleteAsync(customerSigin);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
