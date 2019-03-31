using System;
using System.Linq;
using System.Collections.Generic;


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

    public class WaterVehicle : IWaterVehicle, IGeneralAttributesForVehicle, IDrive, IStart, IStop
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

    public class LandVehicle : ILandVehicle, IGeneralAttributesForVehicle, IStart, IStop, IDrive
    {
        public string Name { get; set;}
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

    public class AirVehicle : IAirVehicle, IGeneralAttributesForVehicle, IStart, IStop, IFly
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


    class Program
    {
        public static void Main()
        {
            //flying vehicles
            var flyingVehicles = new List<AirVehicle>();
            var puddleJumper = new AirVehicle("Puddle Jumper", 0, 1, 10, 1000, 100000000);
            var daedalus = new AirVehicle("Daedalus", 0, 1, 250, 100000, 100000000000000000);
            flyingVehicles.Add(puddleJumper);
            flyingVehicles.Add(daedalus);

            foreach (var ships in flyingVehicles)
            {
                ships.Fly();
                ships.Start();
                ships.Stop();
            }


            //land vehicles
            var landVehicles = new List<LandVehicle>();
            var infinitiG35 = new LandVehicle("Infiniti G35 Coupe", 4, 2, 4, "automatic", 6, 155);
            var kiaOptima = new LandVehicle("Kia Optima", 4, 4, 5, "automatic", 4, 152);
            var fordEdge = new LandVehicle("Ford Edge", 4, 4, 5, "automatic", 6, 135);
            var scionFRS = new LandVehicle("Scion FR-S", 4, 2, 4, "manual", 4, 143);
            landVehicles.Add(infinitiG35);
            landVehicles.Add(kiaOptima);
            landVehicles.Add(fordEdge);
            landVehicles.Add(scionFRS);

            foreach (var cars in landVehicles)
            {
                cars.Drive();
                cars.Start();
                cars.Stop();
            }

            //water vehicles
            var waterVehicles = new List<WaterVehicle>();
            var bassBoat = new WaterVehicle("ProCraft", 0, 3, 250, 88);
            var sailBoat = new WaterVehicle("Sail Boat", 1, 6, 2, 49);
            waterVehicles.Add(bassBoat);
            waterVehicles.Add(sailBoat);

            foreach (var boats in waterVehicles)
            {
                boats.Drive();
                boats.Start();
                boats.Stop();
            }

            Console.ReadLine();
        }
    }
}
