using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
    public int width;
    public int depth;
    public int height;
    public string name;
    public string location;
    public List<Animal> _inhabitants = new List<Animal>();
    public List<Animal> inhabitants
    {
      get
      {
        return _inhabitants;
      }
    }
  }
}