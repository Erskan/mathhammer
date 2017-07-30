using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.models
{
  public class Player
  {
    private Army _army;
    private string _name;

    public Player(Army army, string name)
    {
      _army = army;
      _name = name;
    }

    public Army Army { get => _army; set => _army = value; }
    public string Name { get => _name; set => _name = value; }
  }
}
