namespace Equipment;

public class SoundCard
{
    int yearOfCreation;
    int newPrice;

    public SoundCard(int yearOfCreation, int newPrice)
    {
        this.yearOfCreation = yearOfCreation;
        this.newPrice = newPrice;
    }

    public double GetPrice()
    {
        return yearOfCreation < (DateTime.Today.Year - 4) ? 0 : newPrice - (DateTime.Today.Year - yearOfCreation) * 2000;
    }

    public int GetAge()
    {
        return DateTime.Today.Year - yearOfCreation;
    }
}
