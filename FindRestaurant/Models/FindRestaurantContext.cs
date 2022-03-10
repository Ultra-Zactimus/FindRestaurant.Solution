using Microsoft.EntityFrameworkCore;

namespace FindRestaurant.Models
{
  public class FindRestaurantContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Food> Foods { get; set; }

    public FindRestaurantContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
