using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("Rezervation", Schema = "dbo")]

    public class Rezervation : BasicEntity, IEntity
    {
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Person { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        public string TableType { get; set; }
    }
}
