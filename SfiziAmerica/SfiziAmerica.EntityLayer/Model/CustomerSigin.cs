using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("CustomerSigin", Schema = "dbo")]
    public class CustomerSigin : BasicEntity, IEntity
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }// CKEDITOR
        public string Password { get; set; }
    }
}
