using Microsoft.EntityFrameworkCore;

namespace RestaurantCuisine.Models
{
  public class RestaurantCuisineContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public RestaurantCuisineContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}
