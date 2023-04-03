using Microsoft.AspNetCore.Mvc;
using SfiziAmerica.DataAccessLayer.ModelContext;
using System.Linq;

namespace SfiziAmerica.WebUIandUX.Components
{
    [ViewComponent]
    public class HeaderMenuComponentList : ViewComponent
    {
        private SfizilDatabaseModelContext sfizilDatabase = new SfizilDatabaseModelContext();
        public IViewComponentResult Invoke()
        {
            var list = sfizilDatabase.MenuCategories.Where(x => x.IsActive == true && x.MenuCategoryID == null).OrderBy(x => x.Rank).ToList();
            return View(list);
        }
    }
}
