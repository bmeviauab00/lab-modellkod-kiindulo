namespace Equipment;

public class LedDisplay : DisplayBase
{
    private int responseTime;

    public LedDisplay(int creationYear, int originalPrice, int size, int responseTime)
    {
        this.manufacturingYear = creationYear;
        this.price = originalPrice;
        this.size = size;
        this.responseTime = responseTime;
    }
}
