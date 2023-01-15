using SfiziAmerica.EntityLayer.Model;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Models.ViewModel
{
    public class ApplicationViewModel
    {
        public virtual IList<Catering> Caterings { get; set; }
        public virtual IList<ContactInformation> ContactInformations { get; set; }
        public virtual IList<SocialMedia> SocialMedias { get; set; }
    }
}
