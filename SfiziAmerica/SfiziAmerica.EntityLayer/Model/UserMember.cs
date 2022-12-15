using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("UserMember", Schema = "dbo")]
    public class UserMember : BasicEntity, IEntity
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Guid UserRoleID { get; set; }
        public UserRole UserRole { get; set; }
    }
}
