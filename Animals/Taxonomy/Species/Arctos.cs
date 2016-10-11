namespace Zoolandia.Animals
{
  public class Arctos : Species
  {
    public Arctos()
    {
      this.url = "https://en.wikipedia.org/wiki/Grizzly_bear";
      this.genus = new Ursus();
      this.scientificName = "Ursus Arctos";
      this.commonName = "Grizzly Bear";
    }
  }
}