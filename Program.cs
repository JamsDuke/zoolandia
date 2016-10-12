using System;
using Zoolandia.Animals;

namespace Zoolandia
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Animal Creation
      AfricanElephant elephant = new AfricanElephant();
      elephant.name = "Stampy";
      elephant.species = new Africana();
      elephant.weight = 6800;

      System.Console.WriteLine($"{elephant.name} is a {elephant.species.commonName} weighing an impressive {elephant.weight}lbs.");
      elephant.forage();
      elephant.reproduce(false);
      elephant.eat("leaves");
      elephant.walk();
    }
  }
}
