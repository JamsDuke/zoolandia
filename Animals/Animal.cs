using System;

namespace Zoolandia.Animals
{
  public class Animal : IAnimal
  {
    public Species species { get; set; }
    private string _name = "";
    private string _food = "";
    // private string disposition { get; set; }
    // private string diet { get; set; }
    private int weight = 0;

    public string name
    {
      get
      {
        return _name;
      }
      set
      {
        if (value != "")
        {
          _name = value;
        }
      }
    }
    public string food
    {
      get
      {
        return _food;
      }
      set
      {
        if (value != "")
        {
          _food = value;
        }
      }
    }
    public void eat()
    {
      if (_food == null)
      {
        Console.WriteLine("No food provided yet");
      }
    }
    public virtual void eat(string food)
    {
      _food = food;
      Console.WriteLine("Currently eating {0}", food);
    }
    public virtual void sleep(int hours)
    {
      Console.WriteLine($"{this.name} sleeps for {hours} hours each night.");
    }
    public virtual void move()
    {
      Console.WriteLine($"{this.name} moves about its habitat.");
    }
    public virtual void reproduce(bool pregnant)
    {
      if (pregnant)
      {
        Console.WriteLine($"An adorable {this.species.commonName} has been born in the zoo!");
      }
      else
      {
        Console.WriteLine($"Yet to breed.");
      }
    }
  }
}