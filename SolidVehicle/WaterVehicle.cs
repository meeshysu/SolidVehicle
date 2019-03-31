using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicle
{
    class WaterVehicle : IWaterVehicle, IGeneralAttributesForVehicle, IDrive, IStart, IStop
    {
        public string Name { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public WaterVehicle(string name, int doors, int passengerCapacity, double engineVolume, double maxWaterSpeed)
        {
            Name = name;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxWaterSpeed = maxWaterSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} zips through the waves with the greatest of ease, with {PassengerCapacity} passengers.");
        }

        public void Start()
        {
            Console.WriteLine($"The {Name} starts it's V{EngineVolume} engine.");
        }
        public void Stop()
        {
            Console.WriteLine($"The {Name} stops it's engine after going {MaxWaterSpeed} and the water causes ripples around the boat.");
        }
    }
}
