using TollBoothCalculator.Classes;
using System;
using System.Collections.Generic;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            
            vehicles.Add(new Car(false));
            vehicles.Add(new Car(true));
            vehicles.Add(new Tank());
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));


            var rand = new Random();
            int distanceTotal = 0;
            double tollTotal = 0;

            Console.WriteLine();
            Console.WriteLine("{0, -20} {1, 18} {2, 14}", "Vehicle", "Distance Traveled", "Toll $");
            Console.WriteLine("------------------------------------------------------");

            foreach (IVehicle vehicle in vehicles)
            {
                int distance = rand.Next(10, 240);
                double toll = Math.Round(vehicle.CalculateToll(distance), 2);
                //Console.WriteLine($"{vehicle}, {distance}, ${toll} ");
                Console.WriteLine("{0, -20} {1, 4} {2, 28:C}", vehicle, distance, toll);
           
           
                distanceTotal += distance;
                tollTotal += toll;
            }
            Console.WriteLine();
            Console.WriteLine($"Total Miles Traveled: {distanceTotal}");
            Console.WriteLine($"Total Tollboth Revenue: ${tollTotal}");

        }
    }
}
