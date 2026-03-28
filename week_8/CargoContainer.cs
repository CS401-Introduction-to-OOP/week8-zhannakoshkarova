namespace week_8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> Items { get; set; }

    public CargoContainer()
    {
        Items = new List<T>();
    }

    public void AddItem(T item)
    {
        Items.Add(item);
    }

    public double GetCost()
    {
        double result = 0;
        foreach (var item in Items)
        {
            result += item.CalculateCost();
        }

        return result;
    }
}