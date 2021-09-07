using System;
namespace FactoryProject
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numTires)
        {
            switch (numTires)
            {
                case 2:
                    var item = new MotorCycle();
                    return item.SelectCycleType();
                case 3:
                    return new Trike();

                case 4:
                    var select = new CarOrTruck();
                    return select.SelectCarOrTruck();
                default:
                    return new Boat();
            }
        }
    }
}
