using System;

namespace Zoolandia.Animals
{
  public class Crotalus: Animal
  {
    public string definingFeature { get; set; }
    public override string feed()
    {
      return $"{this.name} has been fed mice because it is a {this.diet}";
    }
  }
}