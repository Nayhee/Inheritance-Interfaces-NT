using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage {get; set;}
        public string GetChargePercentage()
        {
            return $"Current Charge Percentage: {CurrentChargePercentage}%";
        }

        public Tesla(string mainColor, int maximumOccupancy, double batteryKWh, double currentChargePercentage)
        {
            MainColor = mainColor;
            MaximumOccupancy = maximumOccupancy;
            BatteryKWh = batteryKWh;
            CurrentChargePercentage = currentChargePercentage;
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging your vehicle.");
            CurrentChargePercentage = 100;
        }
    }
}