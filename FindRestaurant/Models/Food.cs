using System.Collections.Generic;

namespace FindRestaurant.Models
{
  public class Food
  {
    public Food()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int FoodId { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }

  }
}