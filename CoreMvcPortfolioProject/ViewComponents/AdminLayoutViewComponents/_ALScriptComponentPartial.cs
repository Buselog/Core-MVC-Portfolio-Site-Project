using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents.AdminLayoutViewComponents
{
    public class _ALScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
