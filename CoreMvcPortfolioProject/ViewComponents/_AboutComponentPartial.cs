using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _AboutComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Title = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.SubDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            return View();
        }
    }
}
