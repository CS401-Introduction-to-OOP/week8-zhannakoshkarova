namespace week_8;

public class Parcel: DeliveryItem
{
    public string Dimensions { get; private set; }

    public Parcel(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        Dimensions = "30x20x15";
    }

    public override double CalculateCost()
    {
        double result = 20 + (Weight * 25);
        return result;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}