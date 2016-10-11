namespace Zoolandia.Animals
{
  public class Osphranter : Genus
  {

    public string locomotion { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Red_kangaroo";
      this.trait = "pouch";
      this.commonName = "Red Kangaroo";
      this.scientificName = "Osphranter";
    }

    public Osphranter()
    {
      this.init();
    }
  }
}