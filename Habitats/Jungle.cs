namespace Zoolandia.Habitats
{
  public class Jungle : Habitat, IHeated, IWatered
  {
    public Jungle()
    {
    }
    public double lowHeatTemp { get; set; }
    public double maxHeatTemp { get; set; }
    public string simulatedSeason { get; set; }
    public bool hasFog { get; set; }
    public double waterAmount { get; set; }
    public string waterDeliveryMethod { get; set; }
  }
}