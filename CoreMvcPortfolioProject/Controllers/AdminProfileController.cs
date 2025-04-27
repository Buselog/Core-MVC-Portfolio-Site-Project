using CoreMvcPortfolioProject.DAL.Context;
using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMvcPortfolioProject.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminProfileController : Controller
    {
        private readonly PortfolioContext _context;


        public AdminProfileController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var adminId = HttpContext.Session.GetInt32("adminId");
            if (adminId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var values = _context.Admins.FirstOrDefault(x=>x.AdminId == adminId);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Admin updatedAdmin)
        {

            if (updatedAdmin.ImageFile != null)
            {
                //Uygulamanın çalıştığı dizini al:
                var currentDirectory = Directory.GetCurrentDirectory();

                //Uygulamanın uzantısını al(jpg, png):
                var extension = Path.GetExtension(updatedAdmin.ImageFile.FileName);

                //Benzersiz bir dosya adı oluştur:
                var fileName = Guid.NewGuid().ToString();

                //Kaydedilecek dosyanın yolunu oluştur:
                var saveLocation = Path.Combine(currentDirectory, "wwwroot/images", fileName + extension);

                //Belirtilen konumda bir dosya oluşturur:
                //Fiziksel olarak dosya oluşturmaz ❌
                //Sadece "dosya buraya kaydedilecek" bilgisini hazırlar ✅
                var stream = new FileStream(saveLocation, FileMode.Create);
                //O dosya yolunda fiziksel olarak dosyayı açar/oluşturur


                //Dosyayı fiziksel olarak sunucuya yaz:
                updatedAdmin.ImageFile.CopyTo(stream);
                //Dosyanın içeriğini yazar(yani resmi gerçekten kaydeder)


                updatedAdmin.ImageUrl = "/images/" + fileName + extension;
            }

            _context.Admins.Update(updatedAdmin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult ChangePassword()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(Admin updatedAdmin)
        {

            var values = _context.Admins.FirstOrDefault(x => x.AdminId == HttpContext.Session.GetInt32("adminId"));
            if (values.Password != updatedAdmin.CurrentPassword)
            {
                ModelState.AddModelError("", "Current password is incorrect");
                return View(updatedAdmin);
            }
            if (updatedAdmin.NewPassword != updatedAdmin.ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return View(updatedAdmin);
            }

            values.Password = updatedAdmin.NewPassword;
            _context.SaveChanges();
            return RedirectToAction("LogOut", "Login");
            //return RedirectToAction("Index");
        }

    }
}
