using CoreMvcPortfolioProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcPortfolioProject.ViewComponents
{
    public class _AddressComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _AddressComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Phone = _context.Contacts.Select(x => x.Phone).FirstOrDefault();
            ViewBag.Email = _context.Contacts.Select(x => x.Mail).FirstOrDefault();
            ViewBag.Address = _context.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
