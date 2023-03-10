using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    [Table("MenuCategory", Schema = "dbo")]
    public class MenuCategory : SeoEntity, IEntity
    {
        public MenuCategory()
        {
            MenuCategories = new HashSet<MenuCategory>();
            CategoryMenus = new HashSet<CategoryMenu>();
        }
        public int Rank { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public Guid? MenuCategoryID { get; set; }
        public MenuCategory ParentMenuCategory { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<MenuCategory> MenuCategories { get; set; }
        public virtual ICollection<CategoryMenu> CategoryMenus { get; set; }
    }
}
