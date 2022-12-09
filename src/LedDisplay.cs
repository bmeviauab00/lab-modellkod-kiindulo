namespace Equipment;

public class LedDisplay : DisplayBase, IEquipment
{
    private int responseTime;

    public LedDisplay(int creationYear, int originalPrice, int size, int responseTime)
    {
        this.manufacturingYear = creationYear;
        this.price = originalPrice;
        this.size = size;
        this.responseTime = responseTime;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public int GetAge()
    {
        return DateTime.Today.Year - this.manufacturingYear;
    }

    public string GetDescription()
    {
        return "Led Display";
    }
}
