using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string Details { get; set; }
    private static List<Car> _instances = new List<Car> {};
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    

    public Car(string details, string makeModel, int miles, int price)
    {
      Details = details;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}