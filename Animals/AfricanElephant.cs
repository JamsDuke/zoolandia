using System; 

namespace Zoolandia.Animals
{
  public class AfricanElephant : Animal, IHerbivore, IAmbulatory
  {
    public void forage()
    {
      System.Console.WriteLine($"{this.name} forages for tasty plants.");
    }
    public void walk()
    {
      System.Console.WriteLine($"{this.name} walks around waving its trunk for the hell of it.");
    }
  }
}