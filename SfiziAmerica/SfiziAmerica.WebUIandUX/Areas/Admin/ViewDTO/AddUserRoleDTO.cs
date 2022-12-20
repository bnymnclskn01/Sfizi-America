using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class AddUserRoleDTO
    {
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string RoleCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
