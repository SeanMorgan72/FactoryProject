using System;
namespace FactoryProject
{
    public class RoadsterBike : IVehicle
    {
        public RoadsterBike()
        {
        }

        public void Build()
        {
            Console.WriteLine("You are a take it easy biker, let's build a roadster!");
        }
    }
}
