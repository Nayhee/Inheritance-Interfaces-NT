using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        double CurrentChargePercentage {get;}
        string GetChargePercentage();
    }

    public interface IGasVehicle
    {
        void RefuelTank();
        double CurrentGas {get;}
        string GetGasPercentage();

    }
}