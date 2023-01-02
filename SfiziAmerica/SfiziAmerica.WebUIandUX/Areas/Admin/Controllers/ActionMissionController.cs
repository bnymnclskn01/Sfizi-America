using Mapster;
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
    public class ActionMissionController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionMissionController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/misyon-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.missionRepository.GetAllAsync();
            return View(model);
        }

        [Route("admin/misyon-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/misyon-ekle")]
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> Create(AddMissionDTO addMissionDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            bool missionExist = await unitOfWork.missionRepository.AnyAsync(x => x.Title.ToLower() == addMissionDTO.Title.ToLower());
            if (missionExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            Mision mission = addMissionDTO.Adapt<Mision>();
            if (addMissionDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addMissionDTO.ImageUrl, "Mission");
                if (imgPath == string.Empty)
                    return BadRequest();
                mission.ImageUrl = imgPath;
            }
            await unitOfWork.missionRepository.AddAsync(mission);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/misyon-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var mission = await unitOfWork.missionRepository.GetAsync(x => x.ID == id);
            if (mission == null)
                return RedirectToAction("Index");
            updateMissionViewModel updateMissionViewModel = new() { Mission = mission};
            return View(updateMissionViewModel);
        }

        [Route("admin/misyon-guncelle")]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMissionDTO updateMissionDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });
            var mission = await unitOfWork.missionRepository.GetAsync(x => x.ID == updateMissionDTO.ID);
            if (mission == null)
                return NotFound(new { errorMessage = "There is no information for this record." });
            bool missionExist = await unitOfWork.missionRepository.AnyAsync(x => x.Title.ToLower() == updateMissionDTO.Title.ToLower() && x.ID != updateMissionDTO.ID);
            if (missionExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            if (updateMissionDTO.ImageUrl != null)
            {
                if (System.IO.File.Exists("wwwroot/Image/Mission/" + mission.ImageUrl))
                    System.IO.File.Delete("wwwroot/Image/Mission/" + mission.ImageUrl);
                string imgPath = ImageHelper.CreateImage(updateMissionDTO.ImageUrl, "Mission");
                if (imgPath == string.Empty)
                    return BadRequest();
                mission.ImageUrl = imgPath;
            }
            mission.Title = updateMissionDTO.Title;
            mission.IsActive = updateMissionDTO.IsActive;
            mission.ID = updateMissionDTO.ID;
            mission.Description = updateMissionDTO.Description;
            mission.ShortDescription = updateMissionDTO.ShortDescription;
            mission.LastDate = DateTime.Now;
            await unitOfWork.missionRepository.UpdateAsync(mission);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/misyon-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var misyon = await unitOfWork.missionRepository.GetAsync(x => x.ID == id);
            if (misyon == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Mission/" + misyon.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/Mission/" + misyon.ImageUrl);
            await unitOfWork.missionRepository.DeleteAsync(misyon);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
