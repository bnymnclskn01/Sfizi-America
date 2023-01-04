using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel
{
    public class updateCateringViewModel
    {
        public virtual IList<Catering> Caterings { get; set; }
        public Catering Catering { get; set; }
    }
}
