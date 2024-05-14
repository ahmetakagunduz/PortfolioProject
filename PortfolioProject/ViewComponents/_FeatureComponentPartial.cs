using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
