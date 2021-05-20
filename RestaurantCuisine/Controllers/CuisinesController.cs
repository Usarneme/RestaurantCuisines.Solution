using Microsoft.AspNetCore.Mvc;
using RestaurantCuisine.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantCuisine.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly RestaurantCuisineContext _db;
    public CuisinesController(RestaurantCuisineContext db)
    {
      _db = db;
    }

    [HttpGet("/cuisines")]
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }

    [HttpGet("/cuisines/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/cuisines/create")]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
