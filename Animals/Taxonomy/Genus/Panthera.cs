namespace Zoolandia.Animals
{
  public class Panthera : Genus
  {

    public int claws { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Tiger";
      this.trait = "stripes";
      this.commonName = "Tiger";
      this.scientificName = "Panthera";
    }

    public Panthera()
    {
      this.init();
    }
  }
}