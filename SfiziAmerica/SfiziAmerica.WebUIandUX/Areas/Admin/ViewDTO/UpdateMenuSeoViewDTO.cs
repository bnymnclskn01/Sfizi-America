using System;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateMenuSeoViewDTO : SeoViewDTO
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string PageName { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
