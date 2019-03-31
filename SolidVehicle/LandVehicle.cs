using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicle
{
    class LandVehicle : ILandVehicle, IGeneralAttributesForVehicle, IStart, IStop, IDrive
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public LandVehicle(string name, int wheels, int doors, int passengerCapacity, string transmissionType, double engineVolume, double maxLandSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxLandSpeed = maxLandSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} uses it's V{EngineVolume} to dangerously fly down the highway.");
        }

        public void Start()
        {
            Console.WriteLine($"The {Name} is a(n) {TransmissionType} vehicle that can fit {PassengerCapacity} passengers, has {Wheels} wheels and {Doors} doors.");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Name} stops. Yay.");
        }
    }
}

