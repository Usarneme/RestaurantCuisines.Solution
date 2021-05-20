namespace RestaurantCuisine.Models
{
  public class Restaurant
  {
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public int PhoneNumber { get; set; }

  }
}
