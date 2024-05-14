using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
