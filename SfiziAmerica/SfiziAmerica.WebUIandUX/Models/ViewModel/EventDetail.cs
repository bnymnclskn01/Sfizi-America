using SfiziAmerica.EntityLayer.Model;
using System.Collections;
using System.Collections.Generic;

namespace SfiziAmerica.WebUIandUX.Models.ViewModel
{
    public class EventDetail
    {
        public IList<Event> Events { get; set; }
        public Event Event { get; set; }
        public About About { get; set; }
        public IList<SocialMedia> SocialMedias { get; set; }
    }
}
