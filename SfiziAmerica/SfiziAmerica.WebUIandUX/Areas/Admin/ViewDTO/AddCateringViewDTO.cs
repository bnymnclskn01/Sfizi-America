using SfiziAmerica.EntityLayer.Model;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddCateringViewDTO : SeoViewDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile ImageUrl { get; set; }
        public Guid? parentCateringID { get; set; }
        public string Slug { get; set; }
    }
}
