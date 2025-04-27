using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSkillController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminSkillController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewSkill(Skill newSkill)
        {
            if (!ModelState.IsValid)
            {
                return View(newSkill);
            }
            _context.Skills.Add(newSkill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _context.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill updatedSkill)
        {
            _context.Skills.Update(updatedSkill);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteSkill(int id)
        {
            var values = _context.Skills.Find(id);
            _context.Skills.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
