using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Models.ViewModel
{
    public class ContactViewModel
    {
        public virtual IList<ContactInformation> ContactInformations { get; set; }
        public virtual IList<SocialMedia> SocialMedias { get; set; }
    }
}
