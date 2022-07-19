using System;
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

    internal Car getById(string id)
    {
      Car car = FakeDb.Cars.Find(c => c.Id == id);
      if (car == null)
      {
        throw new Exception("Invalid ID");
      }
      return car;
    }

    internal Car create(Car carData)
    {
      FakeDb.Cars.Add(carData);
      return carData;
    }

    internal Car editCar(Car carData, string id)
    {
      Car found = getById(id);
      found.Make = carData.Make ?? found.Make;
      found.Model = carData.Model ?? found.Model;
      found.Price = carData.Price;
      return found;
    }
  }

}