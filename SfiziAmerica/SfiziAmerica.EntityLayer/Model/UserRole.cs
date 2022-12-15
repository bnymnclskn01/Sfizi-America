using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("UserRole", Schema = "dbo")]
    public class UserRole : BasicEntity, IEntity
    {
        public UserRole()
        {
            UserMembers = new HashSet<UserMember>();
        }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public virtual ICollection<UserMember> UserMembers { get; set; }
    }
}
