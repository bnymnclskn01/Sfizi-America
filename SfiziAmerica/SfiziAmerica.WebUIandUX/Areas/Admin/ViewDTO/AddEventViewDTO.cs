using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddEventViewDTO : SeoViewDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }// CKEDITOR
        [Required]
        public IFormFile ImageUrl { get; set; }
        public string Slug { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
