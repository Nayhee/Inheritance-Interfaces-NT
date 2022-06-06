using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero("Red", 5, 50, 75);
            Zero fx = new Zero("Blue", 5, 50, 75);
            Tesla modelS = new Tesla("Green", 4, 80, 75);

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine(ev.GetChargePercentage());
                ev.ChargeBattery();
                Console.WriteLine(ev.GetChargePercentage());
            }

            /***********************************************/

            Ram ram = new Ram("Red", 5, 50, 75);
            Cessna cessna150 = new Cessna ("Red", 5, 50, 75);

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine(gv.GetGasPercentage());
                gv.RefuelTank();
                Console.WriteLine(gv.GetGasPercentage());
            }
        }
    }
}