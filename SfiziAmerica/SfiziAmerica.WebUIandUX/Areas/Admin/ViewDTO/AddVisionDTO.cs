using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddVisionDTO
    {
        [Required]
        public string Title { get; set; }

        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile ImageUrl { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
