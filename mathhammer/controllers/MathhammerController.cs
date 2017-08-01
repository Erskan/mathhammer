using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mathhammer.utility;
using mathhammer.models;

namespace mathhammer
{
  [Route("api/[controller]")]
  public class MathhammerController : Controller
  {
    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      Army anArmy = DataReader.ReadData(@"D:\Repos\mathhammer\mathhammer\data\chaosspacemarines.json");
      return new string[] { "Armyname:", anArmy.Name };
    }
  }
}
