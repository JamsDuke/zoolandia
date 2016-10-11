using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tiger
            Genus.Panthera Panthera = new Genus.Panthera();
            Species.Tigris Tigris = new Species.Tigris();
            Animal newCat = new Animal()
            {
                name = "Richard Parker",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 500,
                definingFeature = "has stripes",
                Genus = Panthera,
                Species = Tigris
            };
            // Grizzly Bear
            Genus.Ursus Ursus = new Genus.Ursus();
            Species.Arctos Arctos = new Species.Arctos();
            Animal newBear = new Animal()
            {
                name = "Yogi",
                disposition = "aggressive",
                diet = "omnivore",
                weight = 600,
                definingFeature = "loves salmon",
                Genus = Ursus,
                Species = Arctos
            };
            // Red Kangaroo
            Genus.Osphranter Osphranter = new Genus.Osphranter();
            Species.Rufus Rufus = new Species.Rufus();
            Animal newMarsupial = new Animal()
            {
                name = "Rokko",
                disposition = "docile",
                diet = "herbivore",
                weight = 175,
                definingFeature = "hop along",
                Genus = Osphranter,
                Species = Rufus
            };
            // Rattlesnake
            Genus.Crotalus Crotalus = new Genus.Crotalus();
            Species.Atrox Atrox = new Species.Atrox();
            Animal newSnake = new Animal()
            {
                name = "Ricky",
                disposition = "aggressive",
                diet = "carnivore",
                weight = 5,
                definingFeature = "is venomous",
                Genus = Crotalus,
                Species = Atrox
            };
            // Chimpanzee
            Genus.Pan Pan = new Genus.Pan();
            Species.Troglodytes Troglodytes = new Species.Troglodytes();
            Animal newApe = new Animal()
            {
                name = "Bubbles",
                disposition = "aggressive",
                diet = "omnivore",
                weight = 140,
                definingFeature = "is 4 times stronger than a human",
                Genus = Pan,
                Species = Troglodytes
            };
            // African Elephant
            Genus.Loxodonta Loxodonta = new Genus.Loxodonta();
            Species.Africana Africana = new Species.Africana();
            Animal newElephant = new Animal()
            {
                name = "Dumbo",
                disposition = "aggressive",
                diet = "herbivore",
                weight = 140,
                definingFeature = "has tusks",
                Genus = Loxodonta,
                Species = Africana
            };

            Console.WriteLine($"The zoo is currently home to an: {newCat.disposition} {newCat.name}, that is a {newCat.diet} weighing {newCat.weight} lbs and {newCat.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to an: {newBear.disposition} {newBear.name}, that is a {newBear.diet} weighing {newBear.weight} lbs and {newBear.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to a: {newMarsupial.disposition} {newMarsupial.name}, that is a {newMarsupial.diet} weighing {newMarsupial.weight} lbs and can {newMarsupial.definingFeature}.");
            Console.WriteLine($"The zoo is currently home to an: {newSnake.disposition} {newSnake.name}, that is a {newSnake.diet} weighing {newSnake.weight} lbs and {newSnake.definingFeature}.");
            Console.WriteLine(newCat.feed());
            Console.WriteLine(newBear.feed());
            Console.WriteLine(newCat.name);
            Console.WriteLine(newCat.weight);
            Console.WriteLine(newApe.definingFeature);
            Console.WriteLine(newElephant.definingFeature);
        }
    }
}
