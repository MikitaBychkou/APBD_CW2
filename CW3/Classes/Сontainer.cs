namespace CW3;

public abstract class Сontainer(int cargoWeight, int height, int containerWeight, int depth, string serialNumber, int maxLoadWeight)
{
    private static int _nextId = 0;

    public int CargoWeight { get; set; } = cargoWeight;
    public int Height { get; set; } = height;
    public int ContainerWeight { get; set; } = containerWeight;
    public int Depth { get; set; } = depth;
    public string SerialNumber { get; set; } = serialNumber+$"{_nextId}";
    public int MaxLaodWeight { get; set; } = maxLoadWeight;

    public void CargoUnloading()
    {
        CargoWeight = 0;
    } 
    
    public void CargoLoading(int cargoWeight)
    {
        if (cargoWeight > MaxLaodWeight)
        {
            throw new OverfillException("Too much weight of the load");
        }
        CargoWeight = cargoWeight;
    } 
}