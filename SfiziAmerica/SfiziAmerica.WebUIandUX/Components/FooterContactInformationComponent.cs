using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Components
{
    public class FooterContactInformationComponent : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var model = sfizilDatabase.ContactInformations.Where(x => x.IsActive == true).FirstOrDefault();
            return View(model);
        }
    }
}
