using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicle
{
    public interface IGeneralAttributesForVehicle
    {
        string Name { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        double EngineVolume { get; set; }
    }

    public interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }
    }

    public interface ILandVehicle
    {
        int Wheels { get; set; }
        string TransmissionType { get; set; }
        double MaxLandSpeed { get; set; }
    }

    public interface IAirVehicle
    {
        bool Winged { get; set; }
        int Wheels { get; set; }
        double MaxAirSpeed { get; set; }
    }


    public interface IDrive
    {
        void Drive();
    }

    public interface IFly
    {
        void Fly();
    }

    public interface IStart
    {
        void Start();
    }

    public interface IStop
    {
        void Stop();
    }
}
