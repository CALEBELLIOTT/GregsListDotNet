using System.Collections.Generic;
using GregsListDotNet.Models;
using GregsListDotNet.Services;
using Microsoft.AspNetCore.Mvc;




namespace GregsListDotNet.Controllers
{
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
  }
}