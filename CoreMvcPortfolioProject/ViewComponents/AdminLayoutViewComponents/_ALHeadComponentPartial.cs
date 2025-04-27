using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents.AdminLayoutViewComponents
{
    public class _ALHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
