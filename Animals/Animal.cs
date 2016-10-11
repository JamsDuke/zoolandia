using System;

namespace Zoolandia.Animals
{
  class Animal
  {
    public string name { get; set; }

    public string species { get; set; }

    public string disposition { get; set; }

    public string diet { get; set; }

    public int weight { get; set; }

    public virtual string feed()
    {
      return $"{this.name} has been fed";
    }
    public virtual string feed(string name)
    {
      this.name = name;
      return $"This animal has been given the new name of {this.name}";
    }
    public static void sleep()
    {
      Console.WriteLine("Animal is now sleeping");
    }
    public static void play()
    {
      Console.WriteLine("Animal is now playing");
    }
  }
}