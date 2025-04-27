using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreMvcPortfolioProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly PortfolioContext _context;

        public LoginController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            
            var adminInfo = _context.Admins
                .FirstOrDefault(x => x.Email == admin.Email && x.Password == admin.Password);

            if (adminInfo != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, adminInfo.Email),
                    new Claim("adminId", adminInfo.AdminId.ToString()),
                    new Claim("name", adminInfo.Name),
                    new Claim("surname", adminInfo.Surname),
                    new Claim("imageUrl", adminInfo.ImageUrl ?? ""),
                    new Claim(ClaimTypes.Role, "Admin"),
                };

              
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

              
                var principal = new ClaimsPrincipal(identity);

              
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                // 6- (İsteğe Bağlı) Session'a kullanıcı bilgilerini kaydet
                HttpContext.Session.SetString("adminEmail", adminInfo.Email);
                HttpContext.Session.SetInt32("adminId", adminInfo.AdminId);
                HttpContext.Session.SetString("adminName", adminInfo.Name);
                HttpContext.Session.SetString("adminSurname", adminInfo.Surname);
                HttpContext.Session.SetString("adminImageUrl", adminInfo.ImageUrl ?? "");

              
                return RedirectToAction("Index", "AdminProfile");
            }
            else
            {
            
                ModelState.AddModelError("", "Email or password is incorrect");
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {
           
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}
