using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.EntityLayer.Model
{
    public class Logo : BasicEntity, IEntity
    {
        public string Title { get; set; }
        public string LogoUrl { get; set; }
        public string ImageAltTag { get; set; }
    }
}
