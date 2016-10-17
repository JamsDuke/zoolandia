namespace Zoolandia.Animals
{
  public class Loxodondta : Genus
  {

    public int tusks { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/African_elephant";
      this.trait = "trunk";
      this.commonName = "African Elephant";
      this.scientificName = "Loxodondta";
    }

    public Loxodondta()
    {
      this.init();
    }
  }
}