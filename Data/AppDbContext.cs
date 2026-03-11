using BlogShare.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogShare.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
    
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Technology" },
                new Category { Id = 2, CategoryName = "Health" },
                new Category { Id = 3, CategoryName = "LifeStyle" },
                new Category { Id = 4, CategoryName = "Exercise" },
                new Category { Id = 5, CategoryName = "Top Tech News" },
                new Category { Id = 6, CategoryName = "Social Media" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Demo Blog",
                    Content = "Dummy Data",
                    Author = "Anonymous",
                    PublishedDate = new DateTime(2025, 12, 27),
                    CategoryId = 1,
                    FeatureImagePath = "",
                }
            );
        }
    }
}