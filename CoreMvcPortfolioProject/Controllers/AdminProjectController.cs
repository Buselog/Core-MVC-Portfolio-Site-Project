using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminProjectController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminProjectController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Projects.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProject(Projects newProject)
        {
            if (!ModelState.IsValid) return View(newProject);
            _context.Projects.Add(newProject);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var values = _context.Projects.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProject(Projects updatedProject)
        {
            if (!ModelState.IsValid) return View(updatedProject);
            _context.Projects.Update(updatedProject);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteProject(int id)
        {
            var values = _context.Projects.Find(id);
            _context.Projects.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
