using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
