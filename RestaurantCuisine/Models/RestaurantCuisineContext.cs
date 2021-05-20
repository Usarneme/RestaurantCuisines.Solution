using Microsoft.EntityFrameworkCore;

namespace RestaurantCuisine.Models
{
  public class RestaurantCuisineContext : DbContext
  {
    public RestaurantCuisineContext(DbContextOptions options) : base(options) { }
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}
