namespace FindRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int FoodId { get; set; }
    public virtual Food Food { get; set; }
    
  }
}