using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {

        private readonly PortfolioContext _context;

        public _ExperienceComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
