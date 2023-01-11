using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Models.ViewModel
{
    public class AnasayfaViewModel
    {
        public virtual IList<Slider> Sliders { get; set; }
        public virtual About About { get; set; }
        public virtual ContactInformation ContactInformation { get; set; }
        public virtual IList<SocialMedia> SocialMedias { get; set; }
        public virtual IList<Event> Events { get; set; }
        public virtual IList<BookComment> BookComments { get; set; }
        public virtual IList<MenuCategory> MenuCategories { get; set; }
        public virtual IList<Catering> Caterings { get; set; }
    }
}
