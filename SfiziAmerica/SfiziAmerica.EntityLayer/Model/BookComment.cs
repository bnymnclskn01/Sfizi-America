using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("BookComment", Schema = "dbo")]
    public class BookComment : BasicEntity, IEntity
    {
        public string ImageUrl { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
