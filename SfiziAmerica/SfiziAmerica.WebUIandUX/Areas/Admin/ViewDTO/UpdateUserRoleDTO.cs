using System;
using System.ComponentModel.DataAnnotations;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewDTO
{
    public class UpdateUserRoleDTO
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string RoleCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
