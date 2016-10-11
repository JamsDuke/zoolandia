namespace Zoolandia.Animals
{
  public class Tigris : Species
  {
    public Tigris()
    {
      this.url = "https://en.wikipedia.org/wiki/Tiger";
      this.genus = new Panthera();
      this.scientificName = "Panthera Tigris";
      this.commonName = "Tiger";
    }
  }
}