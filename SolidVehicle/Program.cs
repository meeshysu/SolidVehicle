using System;
using System.Linq;
using System.Collections.Generic;


namespace SolidVehicle
{
    public interface IGeneralAttributesForVehicle
    {
         int Wheels { get; set; }
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
         string TransmissionType { get; set; }
         double MaxLandSpeed { get; set; }
    }

    public interface IAirVehicle
    {
         bool Winged { get; set; }
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

    public class JetSki : IWaterVehicle, IGeneralAttributesForVehicle, IDrive, IStart, IStop
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Motorcycle : ILandVehicle, IGeneralAttributesForVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;


        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Cessna : IAirVehicle, IGeneralAttributesForVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; } = 31.1;

        public double MaxAirSpeed { get; set; } = 309.0;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        public static void Main()
        {

            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()


            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
