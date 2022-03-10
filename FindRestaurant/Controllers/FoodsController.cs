using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FindRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace FindRestaurant.Controllers
{
  public class FoodsController : Controller
  {
    private readonly FindRestaurantContext _db;

    public FoodsController(FindRestaurantContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Food> model = _db.Foods.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      try
      {
        Food thisFood = _db.Foods.FirstOrDefault(food => food.FoodId == id);
        return View(thisFood);
      }
      catch
      {
        System.Console.WriteLine("Somebody dropped the baby!");
        return View("Index");
      }
    }
  }
}