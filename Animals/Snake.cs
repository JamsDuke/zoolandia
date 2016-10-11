using System;

namespace Zoolandia.Animals
{
  class CrotalusAtrox: Animal
  {
    public bool venomous { get; set; }
    public override string feed()
    {
      return $"The {this.species} gorges itself on ridiculously cute, little mice.\n{base.feed()}";
    }
    public CrotalusAtrox() : base()
    {
      this.name = "Rattlesnake";
    }
  }
}