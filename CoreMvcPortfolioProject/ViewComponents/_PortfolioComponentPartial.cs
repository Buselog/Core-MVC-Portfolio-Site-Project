using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _PortfolioComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.ToList();
            return View(values);
        }
    }
}
