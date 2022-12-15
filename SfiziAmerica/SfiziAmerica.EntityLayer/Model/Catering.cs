using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("Catering", Schema = "dbo")]
    public class Catering : SeoEntity, IEntity
    {
        public Catering()
        {
            Caterings = new HashSet<Catering>();
            CateringMenus = new HashSet<CateringMenu>();
        }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid? parentCateringID { get; set; }
        public Catering ParentCategory { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<Catering> Caterings { get; set; }
        public virtual ICollection<CateringMenu> CateringMenus { get; set; }
    }
}
