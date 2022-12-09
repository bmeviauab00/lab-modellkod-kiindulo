namespace Equipment;

public class HardDisk : EquipmentBase
{
    private int capacityGB;

    public HardDisk(int yearOfCreation, int newPrice, int capacityGB)
        : base(yearOfCreation, newPrice)
    {
        this.capacityGB = capacityGB;
    }

    public override double GetPrice()
    {
        return yearOfCreation < (DateTime.Today.Year - 4) ? 0 : newPrice - (DateTime.Today.Year - yearOfCreation) * 5000;
    }

    public override string GetDescription()
    {
        return "Hard Disk";
    }
}
