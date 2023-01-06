using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateCateringMenuViewDTO : SeoViewDTO
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public IFormFile ImageUrl1 { get; set; }
        public IFormFile ImageUrl2 { get; set; }
        public IFormFile ImageUrl3 { get; set; }
        public IFormFile ImageUrl4 { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string Type { get; set; }
        public Guid CateringID { get; set; }
        public string Slug { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
