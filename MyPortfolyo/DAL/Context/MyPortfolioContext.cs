using Microsoft.EntityFrameworkCore;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.DAL.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PJJV610\\SQLEXPRESS;Database=MyPortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Experience> Experiences { get; set; } 
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Portofilo> Portofilos { get; set; } 
        public DbSet<Skils> Skills { get; set; } 
        public DbSet<SocialMedia> SocialMedia { get; set; } 
        public DbSet<Testimonial> Testimonials { get; set; } 
    }
}
