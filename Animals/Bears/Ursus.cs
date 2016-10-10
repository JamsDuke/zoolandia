using System;

namespace Zoolandia.Animals
{
  public class Ursus: Animal
  {
    public string definingFeature { get; set; }
    public override string feed()
    {
      return $"{this.name} has been fed meat because it is a {this.diet}";
    }
  }
}