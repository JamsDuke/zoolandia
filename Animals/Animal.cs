using System;

namespace Zoolandia.Animals
{
  class Animal
  {
    public string name { get; set; }

    public string disposition { get; set; }

    public string diet { get; set; }

    public double weight { get; set; }

    public static void sleep ()
    {
      Console.WriteLine("Animal is now sleeping");
    }
  }
}