using System;

namespace Zoolandia.Animals
{
  class OsphranterRufus: Animal
  {
    public string locomotion { get; set; }
    public override string feed()
    {
      return $"The {this.species} enjoys a bale of its favorite grass.\n{base.feed()}";
    }
    public OsphranterRufus() : base()
    {
      this.name = "Red Kangaroo";
    }
  }
}