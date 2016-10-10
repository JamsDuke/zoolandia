using System;

namespace Zoolandia.Animals
{
  public class Loxodonta: Animal
  {
    public string definingFeature { get; set; }
    public override string feed()
    {
      return $"{this.name} has been fed a large shrub because it is a {this.diet}";
    }
  }
}