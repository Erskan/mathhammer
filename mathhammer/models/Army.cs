using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.models
{
  public class Army
  {
    private List<HQ> _hq;
    private List<Elite> _elite;
    private List<Troop> _troop;
    private List<Flyer> _fast;
    private List<Heavy> _heavy;
    private List<Flyer> _flyer;

    public Army(List<HQ> hq, List<Elite> elite, List<Troop> troop, List<Flyer> fast, List<Heavy> heavy, List<Flyer> flyer)
    {
      _hq = hq;
      _elite = elite;
      _troop = troop;
      _fast = fast;
      _heavy = heavy;
      _flyer = flyer;
    }

    public List<HQ> Hq { get => _hq; set => _hq = value; }
    public List<Elite> Elite { get => _elite; set => _elite = value; }
    public List<Troop> Troop { get => _troop; set => _troop = value; }
    public List<Flyer> Fast { get => _fast; set => _fast = value; }
    public List<Heavy> Heavy { get => _heavy; set => _heavy = value; }
    public List<Flyer> Flyer { get => _flyer; set => _flyer = value; }
  }
}
