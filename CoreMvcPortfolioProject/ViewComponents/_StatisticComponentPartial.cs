using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _StatisticComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.ProjectCount = _context.Projects.Count();
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.SkillCount = _context.Skills.Count();
            ViewBag.SkillValuesAvg = _context.Skills.Select(x => x.SkillValue).Average().ToString("0.00", CultureInfo.InvariantCulture);

            return View();
        }
    }
}
