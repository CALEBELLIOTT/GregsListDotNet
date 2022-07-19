using System.Collections.Generic;
using GregsListDotNet.Models;

namespace GregsList.Db
{
  public static class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
      new Car("Honda", "Pilot", 25000, 2015),
      new Car("Toyota", "Prius", 15000, 2018),
      new Car("Jeep", "CJ-5", 7500, 1986)
    };
  }
}