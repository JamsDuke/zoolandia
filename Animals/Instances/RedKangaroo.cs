using System; 

namespace Zoolandia.Animals
{
  public class RedKangaroo : Animal, IHerbivore
  {
    public void forage()
    {
      System.Console.WriteLine($"{this.name} forages for tasty plants.");
    }
  }
}