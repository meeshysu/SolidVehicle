using System;
using System.Linq;
using System.Collections.Generic;


namespace SolidVehicle
{
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
