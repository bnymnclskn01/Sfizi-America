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
    public class ActionUserRoleController : Controller
    {
        DbContext context = new SfizilDatabaseModelContext();
        UnitOfWork unitOfWork;
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
