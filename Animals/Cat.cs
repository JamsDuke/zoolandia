using System;

namespace Zoolandia.Animals
{
  class PantheraTigris: Animal
  {
    public string markings { get; set; }
    public override string feed()
    {
      return $"The {this.species} has been fed a giant red steak.\n{base.feed()}";
    }
    public PantheraTigris() : base()
    {
      this.name = "Bengal Tiger";
    }
    public PantheraTigris(string name) : base()
    {
      this.name = name;
    }
    public PantheraTigris(int weight) : base()
    {
      this.weight = weight;
    }
    public PantheraTigris(string name, int weight) : base()
    {
      this.name = name;
      this.weight = weight;
    }
  }
}