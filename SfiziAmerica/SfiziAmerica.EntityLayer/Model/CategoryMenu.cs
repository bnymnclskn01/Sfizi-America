using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("CategoryMenu", Schema = "dbo")]
    public class CategoryMenu : BasicEntity, IEntity
    {
        public Guid MenuCategoryID { get; set; }
        public MenuCategory MenuCategory { get; set; }
        public Guid MenuID { get; set; }
        public Menu Menu { get; set; }
    }
}
