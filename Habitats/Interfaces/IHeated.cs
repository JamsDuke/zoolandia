namespace Zoolandia.Habitats
{
  public interface IHeated
  {
    double lowHeatTemp { get; set; }
    double maxHeatTemp { get; set; }
    string simulatedSeason { get; set; }
  }
}