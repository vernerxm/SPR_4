namespace СПР_4;

public class Program
{
    static void Main()
    {
        var equipments= new List<SportsEquipment>() { 
            new Barbell(12), 
            new Barbell(10), 
            new Barbell(8), 
            new Barbell(20), 
            new Dumbbell(20),
            new Dumbbell(10)
        };

        for (int i = 0; i < equipments.Count; i++)
        {
            equipments[i].EquipmentPower();
        }
    }
}