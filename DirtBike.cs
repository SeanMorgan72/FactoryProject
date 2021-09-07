using System;
namespace FactoryProject
{
    public class DirtBike : IVehicle
    {
        public DirtBike()
        {
        }

        public void Build()
        {
            Console.WriteLine("You are a daredevil at heart, let's build a dirtbike!");
        }
    }
}
