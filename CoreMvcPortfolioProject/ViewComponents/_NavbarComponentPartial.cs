using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
