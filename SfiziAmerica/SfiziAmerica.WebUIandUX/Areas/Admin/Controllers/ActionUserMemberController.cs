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
    public class ActionUserMemberController : Controller
    {
        DbContext context = new SfizilDatabaseModelContext();
        UnitOfWork unitOfWork;
        public ActionUserMemberController()
        {
            unitOfWork = new(context);
        }
        [Route("admin/kullanici-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.userMemberRepository.GetAllAsync(null, x => x.UserRole);
            return View(model);
        }

        [Route("admin/kullanici-ekle")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userRoleList = await unitOfWork.userRoleRepository.GetAllAsync();
            return View(userRoleList);
        }

        [Route("admin/kullanici-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddUserMemberViewDTO addUserMemberViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });

            bool userMemberExist = await unitOfWork.userMemberRepository.AnyAsync(x => x.Email.ToLower() == addUserMemberViewDTO.Email.ToLower());

            if (userMemberExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            UserMember userMember=addUserMemberViewDTO.Adapt<UserMember>();
            await unitOfWork.userMemberRepository.AddAsync(userMember);
            await unitOfWork.SaveAsync();
            return Ok();
        }


        [Route("admin/kullanici-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var userMmeber = await unitOfWork.userMemberRepository.GetAsync(x => x.ID == id, x => x.UserRole);
            if (userMmeber == null)
                return RedirectToAction("Index");
            var userRoleList = await unitOfWork.userRoleRepository.GetAllAsync();
            updateUserMemberViewModel updateUserMemberViewModel = new() { UserMember = userMmeber, UserRoles = userRoleList };
            return View(updateUserMemberViewModel);
        }

        [Route("admin/kullanici-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUserMemberDTO updateUserMemberDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Lütfen bilgileri doğru girdiğinizden emin olun" });

            var userMember = await unitOfWork.userMemberRepository.GetAsync(x => x.ID == updateUserMemberDTO.ID);

            if (userMember == null)
                return NotFound(new { errorMessage = "Bu kayıta ait bilgi bulunmamaktadır" });

            bool userMemberExist = await unitOfWork.userMemberRepository
                .AnyAsync(x => x.Email.ToLower() == updateUserMemberDTO.Email.ToLower() && x.ID != updateUserMemberDTO.ID);

            if (userMemberExist)
                return BadRequest(new { errorMessage = "Bu isimde bir kayıt zaten bulunmaktadır" });
            userMember.Email= updateUserMemberDTO.Email;
            userMember.ID= updateUserMemberDTO.ID;
            userMember.UserRoleID= updateUserMemberDTO.UserRoleID;
            userMember.Password= updateUserMemberDTO.Password;
            userMember.Phone=updateUserMemberDTO.Phone;
            userMember.IsActive= updateUserMemberDTO.IsActive;
            userMember.NameSurname= updateUserMemberDTO.NameSurname;
            userMember.LastDate = DateTime.Now;
            await unitOfWork.userMemberRepository.UpdateAsync(userMember);
            await unitOfWork.SaveAsync();
            return Ok();
        }


        [Route("admin/kullanici-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userMember = await unitOfWork.userMemberRepository.GetAsync(x => x.ID == id);
            if (userMember==null)
            {
                return NotFound();
            }
            await unitOfWork.userMemberRepository.DeleteAsync(userMember);
            await unitOfWork.SaveAsync();
            return Ok();
        }

    }
}
