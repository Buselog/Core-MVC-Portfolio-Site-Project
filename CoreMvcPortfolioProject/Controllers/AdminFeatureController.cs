using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminFeatureController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminFeatureController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _context.Features.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature updatedFeatures)
        {
            _context.Features.Update(updatedFeatures);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteFeature(int id)
        {
            var values = _context.Features.Find(id);
            _context.Features.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
