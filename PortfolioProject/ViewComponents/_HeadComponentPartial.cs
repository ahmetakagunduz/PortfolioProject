using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
