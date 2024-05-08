using Microsoft.EntityFrameworkCore;
using PortfolioProject.DAL.Entities;

namespace PortfolioProject.DAL.Context
{
    public class MyPortfolioContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SCD3NG6;Database=MyPortfolioDb;Trusted_Connection=True;;TrustServerCertificate=true");
        }
        public DbSet<About>  Abouts { get; set; }   
        public DbSet<Contact>  Contacts { get; set; }   
        public DbSet<Experience>  Experiences { get; set; }   
        public DbSet<Feature> Features { get; set; }   
        public DbSet<Message>  Messages { get; set; }   
        public DbSet<Portfolio> Portfolios { get; set; }   
        public DbSet<Skill>  Skills { get; set; }   
        public DbSet<SocialMedia> SocialMedias { get; set; }   
        public DbSet<Testimonial> Testimonials { get; set; }   
    }
}
