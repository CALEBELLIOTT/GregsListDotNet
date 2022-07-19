using System.Collections.Generic;
using GregsListDotNet.Models;
using GregsListDotNet.Services;
using Microsoft.AspNetCore.Mvc;




namespace GregsListDotNet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {

    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }


    [HttpGet]
    public ActionResult<List<Car>> GetAll()
    {
      try
      {
        List<Car> cars = _cs.GetAll();
        return Ok(cars);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car car = _cs.getById(id);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> create([FromBody] Car carData)
    {
      try
      {
        Car car = _cs.create(carData);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Car> editCar([FromBody] Car carData, string id)
    {
      try
      {
        Car updated = _cs.editCar(carData, id);
        return Ok(updated);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}