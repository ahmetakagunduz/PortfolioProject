using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
