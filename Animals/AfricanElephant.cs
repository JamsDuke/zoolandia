using System; 

namespace Zoolandia.Animals
{
  public class AfricanElephant : Animal, IHerbivore
  {
    public void forage()
    {
        System.Console.WriteLine($"{this.name} forages for tasty plants.");
    }
  }
}