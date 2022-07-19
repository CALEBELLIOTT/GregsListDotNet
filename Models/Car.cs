

using System;

namespace GregsListDotNet.Models
{
  public class Car
  {

    public Car(string make, string model, int price, int year)
    {
      Make = make;
      Model = model;
      Price = price;
      Year = year;
      Id = Guid.NewGuid().ToString();
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }
    public int Year { get; set; }
    public string Id { get; set; }

  }
}