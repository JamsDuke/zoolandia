using System;

namespace Zoolandia.Animals
{
  class UrsusArctos: Animal
  {
    public string coloring { get; set; }
    public override string feed()
    {
      return $"The {this.species} has eaten its weight in alaskan salmon.\n{base.feed()}";
    }
    public UrsusArctos() : base()
    {
      this.name = "Grizzly Bear";
    }
  }
}