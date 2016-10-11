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
  }
}