namespace СПР_4;

public class Dumbbell : SportsEquipment
{
    private double weight;
    public Dumbbell(double _weight) : base (_weight)
    {
        weight = _weight;
        Console.WriteLine("Dumbbell Constructor");
    }
    public override void EquipmentPower()
    {
        Console.WriteLine(weight*gravityAcceleration);
    }

    ~Dumbbell()
    {
        Console.WriteLine("Dumbbell destructor");
    }
}