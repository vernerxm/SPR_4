using System.Security.Cryptography;

namespace СПР_4
{
    public abstract class SportsEquipment
    {
        private double weight;
        public double gravityAcceleration = 9.8;

        protected SportsEquipment(double _weight)
        {
            weight = _weight;
            Console.WriteLine("Constructor");
        }

        public abstract void EquipmentPower();

        ~SportsEquipment()
        {
            Console.WriteLine("Destructor");
        }
}

    
}
