using System;

namespace Zoolandia.Animals
{
  public class Osphranter: Animal
  {
    public string definingFeature { get; set; }
    public override string feed()
    {
      return $"{this.name} has been fed grass because it is a {this.diet}";
    }
  }
}