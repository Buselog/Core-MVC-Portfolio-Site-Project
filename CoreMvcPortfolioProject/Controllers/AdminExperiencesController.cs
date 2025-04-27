using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminExperiencesController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminExperiencesController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewExperience(Experience newExperience)
        {
            if (!ModelState.IsValid)
            {
                return View(newExperience);
            }
            _context.Experiences.Add(newExperience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = _context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience updatedExperience)
        {
            if (!ModelState.IsValid) return View(updatedExperience);
            _context.Experiences.Update(updatedExperience);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _context.Experiences.Find(id);
            _context.Experiences.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
