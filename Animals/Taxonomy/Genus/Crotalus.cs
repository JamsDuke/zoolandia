namespace Zoolandia.Animals
{
  public class Crotalus : Genus
  {

    public bool venomous { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Western_diamondback_rattlesnake";
      this.trait = "rattle tail";
      this.commonName = "Western Diamondback Rattlesnake";
      this.scientificName = "Crotalus";
    }

    public Crotalus()
    {
      this.init();
    }
  }
}