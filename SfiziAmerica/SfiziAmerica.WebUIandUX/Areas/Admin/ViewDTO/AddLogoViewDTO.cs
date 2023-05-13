using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddLogoViewDTO
    {
        public string Title { get; set; }
        public IFormFile LogoUrl { get; set; }
        public string ImageAltTag { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
