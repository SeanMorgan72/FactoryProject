using System;
namespace FactoryProject
{
    public class Trike : IVehicle
    {
        public Trike()
        {
        }

        public void Build()
        {
            Console.WriteLine("Building a trike!\n");
            Console.WriteLine("We are in the twilight zone between car and motorcycle.");
        }
    }
}
