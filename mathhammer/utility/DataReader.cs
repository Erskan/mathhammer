using mathhammer.models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.utility
{
  public static class DataReader
  {
    public static Army ReadData(string path)
    {
      JObject parsedArmy = JObject.Parse(File.ReadAllText(path));
      return new Army(parsedArmy.GetValue("name").ToString())
      {
        Hq = parsedArmy.GetValue("hq").ToObject<List<HQ>>(),
        Elite = parsedArmy.GetValue("elite").ToObject<List<Elite>>(),
        Troop = parsedArmy.GetValue("troop").ToObject<List<Troop>>(),
        Fast = parsedArmy.GetValue("fast").ToObject<List<Fast>>(),
        Heavy = parsedArmy.GetValue("heavy").ToObject<List<Heavy>>(),
        Flyer = parsedArmy.GetValue("flyer").ToObject<List<Flyer>>()
      };
    }
  }
}
