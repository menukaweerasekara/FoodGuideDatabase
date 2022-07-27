using FoodGuide.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodGuide.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodPreference> FoodPreferences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<FoodPreference>().ToTable("FoodPreference");
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
        }

    }
}