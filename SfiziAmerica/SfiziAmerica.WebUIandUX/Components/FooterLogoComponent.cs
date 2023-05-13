using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Components
{
    public class FooterLogoComponent : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var model = sfizilDatabase.Logos.Where(x => x.IsActive == true && x.Title == "Footer Logo").FirstOrDefault();
            return View(model);
        }
    }
}
