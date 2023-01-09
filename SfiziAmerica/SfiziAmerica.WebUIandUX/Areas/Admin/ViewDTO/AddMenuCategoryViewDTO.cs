using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddMenuCategoryViewDTO : SeoViewDTO
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile ImageUrl1 { get; set; }
        public IFormFile ImageUrl2 { get; set; }
        public Guid? MenuCategoryID { get; set; }
        public string Slug { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
