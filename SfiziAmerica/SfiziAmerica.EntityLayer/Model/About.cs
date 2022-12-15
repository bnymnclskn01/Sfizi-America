using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("About", Schema = "dbo")]
    public class About : BasicEntity, IEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }// CKEDITOR
        public string ImageUrl { get; set; }
    }
}
