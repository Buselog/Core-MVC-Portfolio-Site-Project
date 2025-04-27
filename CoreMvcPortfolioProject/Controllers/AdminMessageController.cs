using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private readonly PortfolioContext _context;

        public AdminMessageController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsRead(int id)
        {
            var values = _context.Messages.Find(id);
            if (values.IsRead == false) values.IsRead = true;
            else values.IsRead = false;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DeleteMessage(int id)
        {
            var values = _context.Messages.Find(id);
            _context.Messages.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
