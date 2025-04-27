using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CoreMvcPortfolioProject.Controllers
{
    public class PortfolioLayoutController : Controller
    {
        private readonly PortfolioContext _context;
        public PortfolioLayoutController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           
            var socialMediaList = _context.SocialMedias.ToList();
            ViewBag.SocialMedias = socialMediaList;
            return View();

            //var newMessage = new Message(); // Boş bir mesaj nesnesi oluştur
            //return View(newMessage); // Ana View'e Message gönder
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {

            newMessage.SendDate = DateTime.Now;
            newMessage.IsRead = false;
            _context.Messages.Add(newMessage);
            _context.SaveChanges();
            return RedirectToAction("Index");
           

        }
    }
}
