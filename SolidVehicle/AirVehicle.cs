using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicle
{
    class AirVehicle : IAirVehicle, IGeneralAttributesForVehicle, IStart, IStop, IFly
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public AirVehicle(string name, int wheels, int doors, int passengerCapacity, double engineVolume, double maxAirSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxAirSpeed = engineVolume;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} effortlessly glides through space with {Doors} door(s) that must stay shut at all times. It can hold up to {PassengerCapacity} people.");
        }

        public void Start()
        {
            Console.WriteLine($"The {Name} starts with it's {EngineVolume} volume engine and flies up to it's speed of {MaxAirSpeed}, which is the speed of light... DUH.");
        }

        public void Stop()
        {
            Console.WriteLine($"When {Name} stops, it's not in midair... it's in midspace! HA!");
        }
    }
}
