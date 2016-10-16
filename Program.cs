using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;
using Zoolandia.Structures;

namespace Zoolandia
{
  public class Program
  {
    public static void Main(string[] args)
    {

      // New Grasslands Habitat
      Grasslands grasslands = new Grasslands();
      grasslands.name = "African Paddock";

      // New Deser Habitat
      Desert desert = new Desert();
      desert.name = "Arid Desert";

      // New Forest Habitat
      Forest forest = new Forest();
      forest.name = "Alaskan Wilderness";

      // New Jungle Habitat
      Jungle jungle = new Jungle();
      jungle.name = "Sumatran Jungle";

      // Create Zoo and add Habitats
      Zoo Zoolandia = new Zoo();
      Zoolandia.habitats.Add(desert);
      Zoolandia.habitats.Add(grasslands);
      Zoolandia.habitats.Add(forest);
      Zoolandia.habitats.Add(jungle);

      // Animal Creation
      AfricanElephant elephant = new AfricanElephant();
      elephant.name = "Stampy";
      elephant.species = new Africana();
      elephant.weight = 6800;
      elephant.forage();
      elephant.reproduce(false);
      elephant.eat("leaves");
      elephant.walk();
      elephant.sleep(10);

      RedKangaroo marsupial = new RedKangaroo();
      marsupial.name = "Rokko";
      marsupial.species = new Rufus();
      marsupial.weight = 175;
      marsupial.move();

      GrizzlyBear bear = new GrizzlyBear();
      bear.name = "Yogi";
      bear.species = new Arctos();
      bear.weight = 600;
      bear.reproduce(true);

      Chimpanzee ape = new Chimpanzee();
      ape.name = "Bubbles";
      ape.species = new Troglodytes();
      ape.weight = 200;
      ape.eat("Banana");

      Tiger cat = new Tiger();
      cat.name = "Tony";
      cat.species = new Tigris();
      cat.weight = 450;
      cat.eat();

      Rattlesnake snake = new Rattlesnake();
      snake.name = "Ricky";
      snake.species = new Atrox();
      snake.weight = 5;
      snake.hunt();

      // Add animals to their habitats
      desert.inhabitants.Add(snake);
      desert.inhabitants.Add(marsupial);
      grasslands.inhabitants.Add(elephant);
      forest.inhabitants.Add(bear);
      jungle.inhabitants.Add(ape);
      jungle.inhabitants.Add(cat);

      // Output the habitats in our Zoo
      foreach(Habitat habitat in Zoolandia.habitats)
      {
        Console.WriteLine($"\n{habitat.name}\nAnimals in this habitat:");
        foreach (Animal a in habitat.inhabitants)
        {
          Console.WriteLine($@"   {a.name} the {a.species.commonName} in the genus {a.species.genus.scientificName}.
     More info: {a.species.url}.");
        }
      }

      // System.Console.WriteLine($"{elephant.name} is a {elephant.species.commonName} weighing an impressive {elephant.weight}lbs.");
    }
  }
}
