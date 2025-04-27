using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminTestimonialController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminTestimonialController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTestimonial(Testimonial newTestimonial)
        {
            if (!ModelState.IsValid) return View(newTestimonial);
            _context.Testimonials.Add(newTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial updatedTestimonial)
        {
            if (!ModelState.IsValid) return View(updatedTestimonial);
            _context.Testimonials.Update(updatedTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
