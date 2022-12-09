namespace Equipment;

public static class Program
{
    public static void Main(string[] args)
    {
        EquipmentInventory ei = new EquipmentInventory();

        ei.AddEquipment(new HardDisk(2021, 30000, 80));
        ei.AddEquipment(new HardDisk(2020, 25000, 120));
        ei.AddEquipment(new HardDisk(2020, 25000, 250));

        ei.AddEquipment(new SoundCard(2021, 8000));
        ei.AddEquipment(new SoundCard(2020, 7000));
        ei.AddEquipment(new SoundCard(2020, 6000));

        ei.AddEquipment(new LedDisplay(2020, 80000, 17, 16));
        ei.AddEquipment(new LedDisplay(2021, 70000, 17, 12));

        ei.ListAll();
    }
}
