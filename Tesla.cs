using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; } = 150;
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
        public Tesla(string mainColor, int maximumOccupancy)
        {
            MainColor = mainColor;
            MaximumOccupancy = maximumOccupancy;
        }
    }
}