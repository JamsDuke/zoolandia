using System;

namespace Zoolandia.Animals
{
  public class Tigris: Panthera
  {
    public string commonName = "Tiger";
    public string scientificName = "Panthera Tigris";
    public string feed(int amount, string treat)
    {
      return $"{this.name} has been fed {amount} {treat}s";
    }
  }
}