﻿using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents.AdminLayoutViewComponents
{
    public class _ALFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
