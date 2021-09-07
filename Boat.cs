using System;
namespace FactoryProject
{
    public class Boat : IVehicle
    {
        public Boat()
        {
        }

        public void Build()
        {
            Console.WriteLine("Don't want to be on land for speed, then let's build a boat!");
        }
    }
}
