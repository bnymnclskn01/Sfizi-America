using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;
using System.Threading.Tasks;

namespace SfiziAmerica.WebUIandUX.Components
{
    public class FooterAboutCoımponent : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var model =  sfizilDatabase.Abouts.Where(x => x.IsActive == true).FirstOrDefault();
            return View(model);
        }
    }
}
