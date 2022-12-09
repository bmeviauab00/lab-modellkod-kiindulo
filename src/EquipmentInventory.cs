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
            Console.WriteLine($"Le�r�s: {eq.GetDescription()}\t�letkor: {eq.GetAge()}\t�rt�ke: {eq.GetPrice()}");
        }
    }

    public void AddEquipment(IEquipment eq)
    {
        equipment.Add(eq);
    }
}
