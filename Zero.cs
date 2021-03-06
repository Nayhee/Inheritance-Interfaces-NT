using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; } = 100;
        public double CurrentChargePercentage {get; set;} = 75;
        public string GetChargePercentage()
        {
            return $"Current Charge Percentage: {CurrentChargePercentage}%";
        }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging your vehicle.");
            CurrentChargePercentage = 100;
        }

        public Zero(string mainColor, int maximumOccupancy)
        {
            MainColor = mainColor;
            MaximumOccupancy = maximumOccupancy;
        }
    }
}
