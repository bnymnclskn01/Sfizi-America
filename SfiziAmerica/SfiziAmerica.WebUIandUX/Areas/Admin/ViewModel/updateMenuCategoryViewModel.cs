using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel
{
    public class updateMenuCategoryViewModel
    {
        public virtual IList<MenuCategory> MenuCategories { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}
