using System;
namespace FactoryProject
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }

        public void Build()
        {
            Console.WriteLine("So we have decided to build a truck!");
        }
    }
}
