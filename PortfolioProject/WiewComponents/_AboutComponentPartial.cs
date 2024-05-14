using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WiewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
