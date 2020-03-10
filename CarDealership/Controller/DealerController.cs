using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class DealerController : Controller
  {
    [HttpGet("/dealer")]
    public ActionResult Dealer()
    {
      List<Item> aList = Item.GetAll();
      return View(aList);
    }
    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/index")]
    public ActionResult Index(string makeModel, string price, string miles)
    {
      Car aBrandNewCar = new Car(makeModel, price, miles);
      aBrandNewCar.MakeModel = makeModel;
      aBrandNewCar.Price = price;
      aBrandNewCar.Miles = miles;
      Item anItem = new Item(aBrandNewCar);
      anItem.Description = aBrandNewCar;
      return RedirectToAction("Index");
    }
  }
}