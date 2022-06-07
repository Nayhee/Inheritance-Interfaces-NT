using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero("Red", 1);
            Zero fx = new Zero("Blue", 1);
            Tesla modelS = new Tesla("Blue", 4);

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("------------------------");
            Console.WriteLine("Electric Vehicles:");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine(ev.GetChargePercentage());
                ev.ChargeBattery();
                Console.WriteLine(ev.GetChargePercentage());
            }

            /***********************************************/

            Ram ram = new Ram("Red", 5);
            Cessna cessna1 = new Cessna("Red", 5);

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna1
            };

            Console.WriteLine("------------------------");
            Console.WriteLine("Gas Vehicles:");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine(gv.GetGasPercentage());
                gv.RefuelTank();
                Console.WriteLine(gv.GetGasPercentage());
            }
        }
    }
}