using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _AboutMeComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _AboutMeComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.AboutMe = _context.Abouts.Select(x => x.Detail).FirstOrDefault();
            return View();
        }
    }
}
