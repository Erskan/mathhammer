using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathhammer.models
{
  public class Unit
  {
    private string _name;
    private int _points;
    private int _move;
    private int _ws;
    private int _bs;
    private int _attacks;
    private int _strength;
    private int _toughness;
    private int _wounds;
    private int _maxmodels;
    private int _minmodels;
    private int _numofmodels;
    private List<Rule> _rules;

    #region Constructors
    // Constructors
    public Unit()
    {

    }

    public Unit(string name, int points, int move, int ws, int bs, int attacks, int strength, int toughness, int wounds, int maxmodels, int minmodels, int numofmodels, List<Rule> rules)
    {
      Name = name;
      Points = points;
      Move = move;
      Ws = ws;
      Bs = bs;
      Attacks = attacks;
      Strength = strength;
      Toughness = toughness;
      Wounds = wounds;
      Maxmodels = maxmodels;
      Minmodels = minmodels;
      Numofmodels = numofmodels;
      Rules = rules;
    }
    #endregion

    public string Name { get => _name; set => _name = value; }
    public int Points { get => _points; set => _points = value; }
    public int Move { get => _move; set => _move = value; }
    public int Ws { get => _ws; set => _ws = value; }
    public int Bs { get => _bs; set => _bs = value; }
    public int Attacks { get => _attacks; set => _attacks = value; }
    public int Strength { get => _strength; set => _strength = value; }
    public int Toughness { get => _toughness; set => _toughness = value; }
    public int Wounds { get => _wounds; set => _wounds = value; }
    public List<Rule> Rules { get => _rules; set => _rules = value; }
    public int Maxmodels { get => _maxmodels; set => _maxmodels = value; }
    public int Minmodels { get => _minmodels; set => _minmodels = value; }
    public int Numofmodels { get => _numofmodels; set => _numofmodels = value; }
  }
}
