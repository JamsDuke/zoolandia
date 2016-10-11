namespace Zoolandia.Animals
{
  public class Pan : Genus
  {

    public string toes { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Common_chimpanzee";
      this.trait = "strength of 4 humans";
      this.commonName = "Chimpanzee";
      this.scientificName = "Pan";
    }

    public Pan()
    {
      this.init();
    }
  }
}