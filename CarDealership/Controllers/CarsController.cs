using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string carDetails, string carMake, string miles, string price)
    {
      int carMiles = int.Parse(miles);
      int carPrice = int.Parse(price);
      Car myCar = new Car(carDetails, carMake, carMiles, carPrice);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/sale")]
    public ActionResult Sale()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/cars/sale")]
    public ActionResult CreateSale(string maxPriceInput)
    {
      int maxPrice = int.Parse(maxPriceInput);
      List<Car> newSale = Car.GetAll();
      newSale.WorthBuying(maxPrice);
      List<Car> CarsMatchingSearch = new List<Car>(0);

      
      foreach (Car automobile in allCars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      return View(CarsMatchingSearch);
    }

  }
}