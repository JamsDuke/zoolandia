namespace Zoolandia.Habitats
{
  public interface ICooled
  {
    double lowCoolTemp { get; set; }
    double highCoolTemp { get; set; }
    double airSpeed { get; set; }
    string simulatedSeason { get; set; }
  }
}