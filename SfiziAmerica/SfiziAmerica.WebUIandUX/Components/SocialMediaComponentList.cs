using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Components
{
    public class SocialMediaComponentList : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var list = sfizilDatabase.SocialMedias.Where(x=>x.IsActive).ToList();
            return View(list);
        }
    }
}
