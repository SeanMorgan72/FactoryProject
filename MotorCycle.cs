using System;
namespace FactoryProject
{
    public class MotorCycle : IVehicle
    {
        public MotorCycle()
        {
        }

        public void Build()
        {
            Console.WriteLine("Building a new motorcycle!");
        }

        internal IVehicle SelectCycleType()
        {
            Console.WriteLine("What kind of motorcycle would you like?\n");
            Console.WriteLine("Choices are dirt, speedster, or roadster: ");
            var choice = Console.ReadLine();

            if (choice == "dirt" || choice == "Dirt")
            {
                return new DirtBike();
            }
            else if (choice == "speedster" || choice == "Speedster")
            {
                return new RacerBike();
            }
            else
            {
                return new RoadsterBike();
            }
        }
    }
}