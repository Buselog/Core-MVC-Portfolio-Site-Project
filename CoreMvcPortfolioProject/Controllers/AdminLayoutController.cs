using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminLayoutController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.adminImage = _context.Admins.Select(x => x.ImageUrl).FirstOrDefault();
            return View();
        }
    }
}
