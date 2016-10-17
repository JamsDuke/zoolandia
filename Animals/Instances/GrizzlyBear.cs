using System; 

namespace Zoolandia.Animals
{
  public class GrizzlyBear : Animal, IOmnivore
  {
    public void forage()
    {
      System.Console.WriteLine($"{this.name} forages for tasty plants.");
    }
    public void hunt()
    {
      System.Console.WriteLine($"{this.name} hunts for some meat.");
    }
  }
}