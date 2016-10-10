using System;

namespace Zoolandia.Animals
{
  public class Pan: Animal
  {
    public string definingFeature { get; set; }
    public override string feed()
    {
      return $"{this.name} has been fed fruit and grubs because it is a {this.diet}";
    }
  }
}