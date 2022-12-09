namespace Equipment;

public class EquipmentInventory
{
    private List<IEquipment> equipment;

    public EquipmentInventory()
    {
        equipment = new List<IEquipment>();
    }

    public void ListAll()
    {
        foreach (IEquipment eq in equipment)
        {
            Console.WriteLine($"Leírás: {eq.GetDescription()}\tÉletkor: {eq.GetAge()}\tÉrtéke: {eq.GetPrice()}");
        }
    }

    public void AddEquipment(IEquipment eq)
    {
        equipment.Add(eq);
    }
}
