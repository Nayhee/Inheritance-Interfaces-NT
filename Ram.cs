using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentGas {get; set;}
        public string GetGasPercentage()
        {
            return $"Current Gas In Tank: {CurrentGas}%";
        }

        public Ram(string mainColor, int maximumOccupancy, double fuelCapacity, double currentGas)
        {
            MainColor = mainColor;
            MaximumOccupancy = maximumOccupancy;
            FuelCapacity = fuelCapacity;
            CurrentGas = currentGas;
        }

        public void RefuelTank()
        {
            Console.WriteLine("Filling your tank with gas.");
            CurrentGas = 100;
        }
    }
}