using System;
namespace FactoryProject
{
    public class RacerBike : IVehicle
    {
        public RacerBike()
        {
        }

        public void Build()
        {
            Console.WriteLine("You have the need for speed, let's build a speed bike!");
        }
    }
}
