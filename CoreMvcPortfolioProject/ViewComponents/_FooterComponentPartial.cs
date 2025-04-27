using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;
        public _FooterComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }

    }
}
