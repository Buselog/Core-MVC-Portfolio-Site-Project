using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {

        private readonly PortfolioContext _context;

        public _FeatureComponentPartial(PortfolioContext context)  // Program.cs'ten verilir
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Title = _context.Features.Select(x => x.Title).FirstOrDefault(); // Select -> sütun seçer, where şartlı ifade için kullanılır.
            ViewBag.Description = _context.Features.Select(x => x.Description).FirstOrDefault();
      
            return View();
        }
    }
}
