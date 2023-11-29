namespace СПР_4;

public class Barbell: SportsEquipment
{
    private double weight;
    public Barbell(double _weight) : base (_weight)
    {
        weight = _weight;
        Console.WriteLine("Barbell Constructor");
    }
    public override void EquipmentPower()
    {
        Console.WriteLine(weight*gravityAcceleration);
    }

    ~Barbell()
    {
        Console.WriteLine("Barbell destructor");
    }
}