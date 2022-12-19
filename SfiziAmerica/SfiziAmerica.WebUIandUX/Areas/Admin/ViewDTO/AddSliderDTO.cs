using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddSliderDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Rank { get; set; }
        [Required]
        public IFormFile ImageVideoUrl { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
