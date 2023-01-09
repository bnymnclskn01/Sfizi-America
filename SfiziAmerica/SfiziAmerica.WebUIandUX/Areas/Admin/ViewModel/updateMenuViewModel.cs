using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel
{
    public class updateMenuViewModel
    {
        public virtual IList<MenuCategory> MenuCategories { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
