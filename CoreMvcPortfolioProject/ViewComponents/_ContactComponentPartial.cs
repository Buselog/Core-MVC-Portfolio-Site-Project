using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {

        private readonly PortfolioContext _context;

        public _ContactComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            var message = new Message(); // Boş model
            return View(message);
        }

    }
}
