using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController : Controller
    {
        private readonly PortfolioContext _context;
        public AdminDashboardController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ProjectCount = _context.Projects.Count();
            ViewBag.SkillAverage = _context.Skills.Select(x => x.SkillValue).Average().ToString("0.0", CultureInfo.InvariantCulture);
            ViewBag.MessageCount = _context.Messages.Count();
            ViewBag.UnreadMessageCount = _context.Messages.Where(x => x.IsRead == false).Count();

            ViewBag.Last4Skills = _context.Skills.OrderByDescending(x => x.SkillId).Take(4).ToList();
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.LastExperienceName = _context.Experiences.OrderBy(x => x.ExperienceId).Select(x => x.Head).FirstOrDefault();
            ViewBag.TestimonialCount = _context.Testimonials.Count();

            ViewBag.Messages = _context.Messages.ToList();
            return View();
        }
    }
}
