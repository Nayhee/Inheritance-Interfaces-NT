using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; } = 200;
        public double CurrentGas {get; set;} = 75;

        public string GetGasPercentage()
        {
            return $"Current Gas In Tank: {CurrentGas}%";
        }
        public void RefuelTank()
        {
            Console.WriteLine("Filling your tank with gas.");
            CurrentGas = 100;
        }
        public Cessna(string mainColor, int maximumOccupancy)
        {
            MainColor = mainColor;
            MaximumOccupancy = maximumOccupancy;
        }
    }
}
