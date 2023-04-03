using SfiziAmerica.EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Models.ViewModel
{
    public class PageMenuModel
    {
        public virtual MenuCategory MenuCategory { get; set; }
        public virtual IList<MenuCategory> MenuCategories { get; set; }
    }
}
