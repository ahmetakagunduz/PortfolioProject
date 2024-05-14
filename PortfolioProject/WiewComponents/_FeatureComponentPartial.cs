using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WiewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
