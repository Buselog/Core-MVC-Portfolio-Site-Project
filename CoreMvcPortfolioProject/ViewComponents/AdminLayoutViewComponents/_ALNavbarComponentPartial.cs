using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents.AdminLayoutViewComponents
{
    public class _ALNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
