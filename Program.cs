using System;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTires;
            bool input;
            do
            {
                Console.WriteLine("Enter the number of tires of the type of vehicle you want to build: ");
                
                input = int.TryParse(Console.ReadLine(), out numTires);
            }
            while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numTires);
            vehicle.Build();
        }
    }
}
