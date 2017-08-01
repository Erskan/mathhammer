using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.models
{
  public class Army
  {
    private string _name;
    private List<HQ> _hq;
    private List<Elite> _elite;
    private List<Troop> _troop;
    private List<Fast> _fast;
    private List<Heavy> _heavy;
    private List<Flyer> _flyer;

    // Name must be provided
    public Army(string name)
    {
      Name = name;
    }

    public Army(string name, List<HQ> hq, List<Elite> elite, List<Troop> troop, List<Fast> fast, List<Heavy> heavy, List<Flyer> flyer)
    {
      _name = name;
      _hq = hq;
      _elite = elite;
      _troop = troop;
      _fast = fast;
      _heavy = heavy;
      _flyer = flyer;
    }

    public string Name { get => _name; set => _name = value; }
    public List<HQ> Hq { get => _hq; set => _hq = value; }
    public List<Elite> Elite { get => _elite; set => _elite = value; }
    public List<Troop> Troop { get => _troop; set => _troop = value; }
    public List<Fast> Fast { get => _fast; set => _fast = value; }
    public List<Heavy> Heavy { get => _heavy; set => _heavy = value; }
    public List<Flyer> Flyer { get => _flyer; set => _flyer = value; }
  }
}
