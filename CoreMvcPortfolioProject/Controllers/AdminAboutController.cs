using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminAboutController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminAboutController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _context.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About updatedAbout)
        {
            _context.Abouts.Update(updatedAbout);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteAbout(int id)
        {
            var values = _context.Abouts.Find(id);
            _context.Abouts.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
