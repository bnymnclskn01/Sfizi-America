using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddMenuSeoViewDTO : SeoViewDTO
    {
        [Required]
        public string PageName { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
