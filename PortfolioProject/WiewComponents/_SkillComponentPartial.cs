﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WiewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}