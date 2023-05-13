using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Components
{
    public class HeadLogoComponent : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var model = sfizilDatabase.Logos.Where(x => x.IsActive == true && x.Title == "Üst Logo").FirstOrDefault();
            return View(model);
        }
    }
}
