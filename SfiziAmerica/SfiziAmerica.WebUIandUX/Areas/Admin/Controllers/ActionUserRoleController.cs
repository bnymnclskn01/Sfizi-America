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
    public class ActionUserRoleController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionUserRoleController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/kullanici-rol-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.userRoleRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/kullanici-rol-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [Route("admin/kullanici-rol-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddUserRoleDTO addUserRoleDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            bool userRoleExist = await unitOfWork.userRoleRepository.AnyAsync(x => x.RoleName.ToLower() == addUserRoleDTO.RoleName.ToLower() || x.RoleCode.ToLower() == addUserRoleDTO.RoleCode.ToLower());
            if (userRoleExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            UserRole userRole = addUserRoleDTO.Adapt<UserRole>();
            await unitOfWork.userRoleRepository.AddAsync(userRole);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/kullanici-rol-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var userRole = await unitOfWork.userRoleRepository.GetAsync(x => x.ID == id);
            if (userRole == null)
                return RedirectToAction("Index");
            updateUserRoleViewModel updateUserRoleViewModel = new() { UserRole = userRole };
            return View(updateUserRoleViewModel);
        }

        [Route("admin/kullanici-rol-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUserRoleDTO updateUserRoleDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });
            var userRole = await unitOfWork.userRoleRepository.GetAsync(x => x.ID == updateUserRoleDTO.ID);
            if (userRole == null)
                return NotFound(new { errorMessage = "Bu kayıta ait bilgi bulunmamaktadır" });
            bool userRoleExist = await unitOfWork.userRoleRepository.AnyAsync(x => x.RoleName.ToLower() == updateUserRoleDTO.RoleName.ToLower() && x.ID != updateUserRoleDTO.ID);
            if (userRoleExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            userRole.RoleName = updateUserRoleDTO.RoleName;
            userRole.IsActive = updateUserRoleDTO.IsActive;
            userRole.ID = updateUserRoleDTO.ID;
            userRole.RoleCode = updateUserRoleDTO.RoleCode;
            userRole.LastDate = DateTime.Now;
            await unitOfWork.userRoleRepository.UpdateAsync(userRole);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/kullanici-rol-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userRole = await unitOfWork.userRoleRepository.GetAsync(x => x.ID == id);
            if (userRole == null)
            {
                return NotFound();
            }
            await unitOfWork.userRoleRepository.DeleteAsync(userRole);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
