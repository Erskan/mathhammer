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
      Army newArmy = new Army(parsedArmy.GetValue("name").ToString());
      return newArmy;
    }
  }
}
