using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WiewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
