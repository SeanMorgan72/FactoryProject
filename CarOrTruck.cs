using System;
namespace FactoryProject
{
    public class CarOrTruck : IVehicle
    {
        public CarOrTruck()
        {
        }

        public void Build()
        {
            Console.WriteLine("Building a new car or truck!");
        }

        internal IVehicle SelectCarOrTruck()
        {
            Console.WriteLine("Would you like to buile either a car or truck?");
            var choice = Console.ReadLine();

            if(choice == "car" || choice == "Car")
            {
                return new Car();
            }
            else
            {
                return new Truck();
            }
        }
    }
}
