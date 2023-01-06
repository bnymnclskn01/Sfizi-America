using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel
{
    public class updateCateringMenuViewModel
    {
        public  CateringMenu CateringMenu { get; set; }
        public virtual IList<Catering> Caterings { get; set; }
    }
}
