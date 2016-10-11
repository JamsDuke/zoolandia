namespace Zoolandia.Animals
{
  public class Troglodytes : Species
  {
    public Troglodytes()
    {
      this.url = "https://en.wikipedia.org/wiki/Common_chimpanzee";
      this.genus = new Pan();
      this.scientificName = "Pan Troglodytes";
      this.commonName = "Chimpanzee";
    }
  }
}
