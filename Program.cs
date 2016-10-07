using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PantheraTigris newCat = new PantheraTigris()
            {
                name = "Bengal Tiger",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 500,
                markings = "stripes"

            };
            UrsusArctos newBear = new UrsusArctos()
            {
                name = "Grizzly Bear",
                disposition = "aggressive",
                diet = "omnivore",
                weight = 600,
                coloring = "brown"
            };
            OsphranterRufus newMarsupial = new OsphranterRufus()
            {
                name = "Red Kangaroo",
                disposition = "docile",
                diet = "herbivore",
                weight = 175,
                locomotion = "hopping"
            };
            CrotalusAtrox newSnake = new CrotalusAtrox()
            {
                name = "Rattlesnake",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 5,
                venomous = true
            };

            Console.WriteLine($"The zoo is currently home to an: {newCat.disposition} {newCat.name}, that is a {newCat.diet} weighing {newCat.weight} lbs with {newCat.markings}.");
            Console.WriteLine($"The zoo is currently home to an: {newBear.disposition} {newBear.name}, that is a {newBear.diet} weighing {newBear.weight} lbs with {newBear.coloring} fur.");
            Console.WriteLine($"The zoo is currently home to a: {newMarsupial.disposition} {newMarsupial.name}, that is a {newMarsupial.diet} weighing {newMarsupial.weight} lbs and can be seen {newMarsupial.locomotion}.");
            Console.WriteLine($"The zoo is currently home to an: {newSnake.disposition} {newSnake.name}, that is a {newSnake.diet} weighing {newSnake.weight} lbs.");
        }
    }
}
