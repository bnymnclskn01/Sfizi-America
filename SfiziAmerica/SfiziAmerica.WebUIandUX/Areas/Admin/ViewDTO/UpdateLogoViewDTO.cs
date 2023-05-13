using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateLogoViewDTO
    {
        [Required]
        public Guid ID { get; set; }
        public string Title { get; set; }
        public IFormFile LogoUrl { get; set; }
        public string ImageAltTag { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
