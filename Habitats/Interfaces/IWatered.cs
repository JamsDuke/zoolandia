namespace Zoolandia.Habitats
{
  public interface IWatered
  {
    bool hasFog { get; set; }
    double waterAmount { get; set; }
    string waterDeliveryMethod { get; set; }
  }
}