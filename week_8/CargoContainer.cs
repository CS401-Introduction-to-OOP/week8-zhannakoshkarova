namespace week_8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> items;

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public double GetCost()
    {
        double result = 0;
        foreach (var item in items)
        {
            result += item.CalculateCost();
        }

        return result;
    }
}