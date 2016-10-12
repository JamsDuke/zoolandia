using System;

namespace Zoolandia.Animals
{
  public class Animal
  {
    public Genus.Genus Genus { get; set; }
    public Species.Species Species { get; set; }
    public string name { get; set; }
    public string disposition { get; set; }
    public string diet { get; set; }
    public int weight { get; set; }
    public string definingFeature { get; set; }
    public virtual string feed()
    {
      return $"{this.name} has been fed";
    }
    public virtual string nameAnimal(string name)
    {
      this.name = name;
      return $"This animal has been given the new name of {this.name}";
    }
  }
}