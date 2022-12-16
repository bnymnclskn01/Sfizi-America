using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateVisionDTO
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; } // CKEDITOR
        public IFormFile ImageUrl { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
