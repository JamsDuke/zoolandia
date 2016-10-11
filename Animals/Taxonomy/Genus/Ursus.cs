namespace Zoolandia.Animals
{
  public class Ursus : Genus
  {

    public int claws { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Grizzly_bear";
      this.trait = "loves salmon";
      this.commonName = "Grizzly Bear";
      this.scientificName = "Ursus";
    }

    public Ursus()
    {
      this.init();
    }
  }
}