using System.Collections.Generic;
using GregsList.Db;
using GregsListDotNet.Models;

namespace GregsListDotNet.Services
{

  public class CarsService
  {

    internal List<Car> GetAll()
    {
      return FakeDb.Cars;
    }
  }

}