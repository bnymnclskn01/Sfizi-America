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
    public class ActionEventController : Controller
    {
        private DbContext context = new SfizilDatabaseModelContext();
        private UnitOfWork unitOfWork;
        public ActionEventController()
        {
            unitOfWork = new(context);
        }

        [Route("admin/etkinlik-listele")]
        public async Task<IActionResult> Index()
        {
            var model = await unitOfWork.eventRepository.GetAllAsync();
            return View(model);
        }


        [Route("admin/etkinlik-ekle")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("admin/etkinlik-ekle")]
        [HttpPost]
        public async Task<IActionResult> Create(AddEventViewDTO addEventViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly." });
            bool eventExist = await unitOfWork.eventRepository.AnyAsync(x => x.Title.ToLower() == addEventViewDTO.Title.ToLower());
            if (eventExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            Event events = addEventViewDTO.Adapt<Event>();
            if (addEventViewDTO.ImageUrl != null)
            {
                string imgPath = ImageHelper.CreateImage(addEventViewDTO.ImageUrl, "Event");
                if (imgPath == string.Empty)
                    return BadRequest();
                events.ImageUrl = imgPath;
            }
            events.seoDesign = "ImproBioTech and Infromation Technology";
            events.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            events.seoAuthor = "ImproBioTech and Information Technology";
            events.seoSubject = "Restaurant";
            events.Slug = StringHelper.StringReplacer(addEventViewDTO.Title).ToLower();
            await unitOfWork.eventRepository.AddAsync(events);
            await unitOfWork.SaveAsync();
            return Ok();
        }

        [Route("admin/etkinlik-guncelle/{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var events = await unitOfWork.eventRepository.GetAsync(x => x.ID == id);
            if (events == null)
                return RedirectToAction("Index");
            updateEventViewModel updateEventViewModel = new() { Event = events };
            return View(updateEventViewModel);
        }

        [Route("admin/etkinlik-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateEventViewDTO updateEventViewDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errorMessage = "Please make sure you have entered the information correctly" });

            bool eventExist = await unitOfWork.eventRepository.AnyAsync(x => x.Title.ToLower() == updateEventViewDTO.Title.ToLower() && x.ID != updateEventViewDTO.ID);
            var events = await unitOfWork.eventRepository.GetAsync(x => x.ID == updateEventViewDTO.ID);
            if (events == null)
                return NotFound(new { errorMessage = "There is no information about this record." });
            if (eventExist)
                return BadRequest(new { errorMessage = "A record with this name already exists." });
            events.Title = updateEventViewDTO.Title;
            events.ShortDescription = updateEventViewDTO.ShortDescription;
            events.Description = updateEventViewDTO.Description;
            events.Slug = StringHelper.StringReplacer(updateEventViewDTO.Title).ToLower();
            events.IsActive = updateEventViewDTO.IsActive;
            events.LastDate = DateTime.Now;
            #region seo
            events.seoDescription = updateEventViewDTO.seoDescription;
            events.seoFacebookDescription = updateEventViewDTO.seoFacebookDescription;
            events.seoFacebookKeywrods = updateEventViewDTO.seoFacebookKeywrods;
            events.seoFacebookTitle = updateEventViewDTO.seoFacebookTitle;
            events.seoFacebookUrl = updateEventViewDTO.seoFacebookUrl;
            events.seoReply = updateEventViewDTO.seoReply;
            events.seoTitle = updateEventViewDTO.seoTitle;
            events.seoKeywords = updateEventViewDTO.seoKeywords;
            events.seoTwitterDescription = updateEventViewDTO.seoTwitterDescription;
            events.seoTwitterKeywords = updateEventViewDTO.seoTwitterKeywords;
            events.seoTwitterTitle = updateEventViewDTO.seoTwitterTitle;
            events.seoTwitterUrl = updateEventViewDTO.seoTwitterUrl;
            events.seoDesign = "ImproBioTech and Infromation Technology";
            events.seoCopyright = "Copyright © 2022 SFIZI Tüm Hakları Saklıdır. Design By ImproBioTech";
            events.seoAuthor = "ImproBioTech and Information Technology";
            events.seoSubject = "Restaurant";
            #endregion
            return Ok();
        }


        [Route("admin/etkinlik-sil/{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var events = await unitOfWork.eventRepository.GetAsync(x => x.ID == id);
            if (events == null)
                return NotFound();
            if (System.IO.File.Exists("wwwroot/Image/Event/" + events.ImageUrl))
                System.IO.File.Delete("wwwroot/Image/Event/" + events.ImageUrl);
            await unitOfWork.eventRepository.DeleteAsync(events);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}
