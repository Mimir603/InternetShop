using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;

namespace WebApplication12.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1111111, Name = "FairyTales", OrderDisplay = 1 },
                    new Category { Id = 222222, Name = "Sci-Fi", OrderDisplay = 2 },
                    new Category { Id = 333333, Name = "Thriller", OrderDisplay = 3 }
                );
        }
        public DbSet<Category> Categories { get; set; }
    }
}
