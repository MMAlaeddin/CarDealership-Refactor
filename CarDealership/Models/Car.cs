using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public string Price { get; set; }
    public string Miles { get; set; }

    public Car(string makeModel, string price, string miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
  }
  public class Item
  {
    public Dealership.Models.Car Description { get; set; }
    private static List<Item> _instances = new List<Item>{};

    public Item(Dealership.Models.Car description)
    {
      Description = description;
      _instances.Add(this);
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
  }
}