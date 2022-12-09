using System;

namespace Equipment;

public class HardDisk
{
    private int yearOfCreation;
    private int newPrice;
    private int capacityGB;

    public HardDisk(int yearOfCreation, int newPrice, int capacityGB)
    {
        this.yearOfCreation = yearOfCreation;
        this.newPrice = newPrice;
        this.capacityGB = capacityGB;
    }

    public double GetPrice()
    {
        return yearOfCreation < (DateTime.Today.Year - 4) ? 0 : newPrice - (DateTime.Today.Year - yearOfCreation) * 5000;
    }

    public int GetAge()
    {
        return DateTime.Today.Year - yearOfCreation;
    }
}
