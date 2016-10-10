using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tigris newCat = new Tigris()
            {
                name = "Richard Parker",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 500,
                definingFeature = "has stripes"
            };
            Arctos newBear = new Arctos()
            {
                name = "Yogi",
                disposition = "aggressive",
                diet = "omnivore",
                weight = 600,
                definingFeature = "loves salmon"
            };
            Rufus newMarsupial = new Rufus()
            {
                name = "Rokko",
                disposition = "docile",
                diet = "herbivore",
                weight = 175,
                definingFeature = "hop along"
            };
            Atrox newSnake = new Atrox()
            {
                name = "Ricky",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 5,
                definingFeature = "is venomous"
            };
            Pan newApe = new Pan()
            {
                name = "Bubbles",
                disposition = "aggressive",
                diet = "omnivore",
                weight = 140,
                definingFeature = "is 4 times stronger than a human"
            };
            Loxodonta newElephant = new Loxodonta()
            {
                name = "Dumbo",
                disposition = "aggressive",
                diet = "herbivore",
                weight = 140,
                definingFeature = "has tusks"
            };

            Console.WriteLine($"The zoo is currently home to an: {newCat.disposition} {newCat.commonName}, that is a {newCat.diet} weighing {newCat.weight} lbs and {newCat.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to an: {newBear.disposition} {newBear.commonName}, that is a {newBear.diet} weighing {newBear.weight} lbs and {newBear.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to a: {newMarsupial.disposition} {newMarsupial.commonName}, that is a {newMarsupial.diet} weighing {newMarsupial.weight} lbs and can {newMarsupial.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to an: {newSnake.disposition} {newSnake.commonName}, that is a {newSnake.diet} weighing {newSnake.weight} lbs and {newSnake.definingFeature}.");
            Console.WriteLine(newCat.feed());
            Console.WriteLine(newBear.feed());
            Console.WriteLine(newMarsupial.feed());
            Console.WriteLine(newSnake.feed());
            Console.WriteLine(newCat.name);
            Console.WriteLine(newCat.weight);
            Console.WriteLine(newApe.definingFeature);
            Console.WriteLine(newElephant.definingFeature);
        }
    }
}
