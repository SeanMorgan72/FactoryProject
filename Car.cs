using System;
namespace FactoryProject
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Build()
        {
            Console.WriteLine("So we have decided to build a car!");
        }
    }
}
