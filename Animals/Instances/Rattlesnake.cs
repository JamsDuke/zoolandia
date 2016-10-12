using System; 

namespace Zoolandia.Animals
{
  public class Rattlesnake : Animal, ICarnivore
  {
    public void hunt()
    {
      System.Console.WriteLine($"{this.name} hunts for little mice.");
    }
  }
}