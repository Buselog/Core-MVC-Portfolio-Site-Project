using CoreMvcPortfolioProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcPortfolioProject.DAL.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-V7IDV6Q\\SQLEXPRESS01; Initial Catalog= PortfolioDb; Integrated Security= True;");
        }


        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
