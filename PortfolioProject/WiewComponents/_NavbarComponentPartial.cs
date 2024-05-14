using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WiewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
