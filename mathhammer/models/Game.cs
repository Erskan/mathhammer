using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.models
{
  public class Game
  {
    private List<Player> _players;
    private List<Army> _armies;

    public List<Player> Players { get => _players; set => _players = value; }
    public List<Army> Armies { get => _armies; set => _armies = value; }
  }
}
