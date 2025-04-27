using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMvcPortfolioProject.DAL.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string CurrentPassword { get; set; }

        [NotMapped]
        public string NewPassword { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}
