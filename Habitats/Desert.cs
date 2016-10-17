namespace Zoolandia.Habitats
{
  public class Desert : Habitat, IHeated, IWatered, ICooled
  {
    public Desert()
    {
    }
    public double lowHeatTemp { get; set; }
    public double maxHeatTemp { get; set; }
    public string simulatedSeason { get; set; }
    public bool hasFog { get; set; }
    public double waterAmount { get; set; }
    public string waterDeliveryMethod { get; set; }
    public double lowCoolTemp { get; set; }
    public double highCoolTemp { get; set; }
  }
}