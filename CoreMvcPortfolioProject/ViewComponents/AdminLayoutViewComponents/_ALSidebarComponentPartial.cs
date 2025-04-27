using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents.AdminLayoutViewComponents
{
    public class _ALSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
