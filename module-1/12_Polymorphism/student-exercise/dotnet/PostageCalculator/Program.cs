using System;
using System.Collections.Generic;
using PostageCalculator;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the weight of the package?");
            string inputWeightStr = Console.ReadLine();
            double inputWeight = double.Parse(inputWeightStr);
            Console.WriteLine("(P)ounds or (O)unces?");
            string poundsOrOunces = Console.ReadLine();
            Console.WriteLine("What distance will it be traveling?");
            string inputDistanceStr = Console.ReadLine();
            int inputDistance = int.Parse(inputDistanceStr);

            if (poundsOrOunces == "P")
            {
                inputWeight *= 16;
            }
            
            
            List<IDeliveryDriver> deliveryOptions = new List<IDeliveryDriver>();

            deliveryOptions.Add(new PostalServiceFirstClass());
            deliveryOptions.Add(new PostalServiceSecondClass());
            deliveryOptions.Add(new PostalServiceThirdClass());
            deliveryOptions.Add(new FexEd());           
            deliveryOptions.Add(new SPU4Day());
            deliveryOptions.Add(new SPU2Day());
            deliveryOptions.Add(new SPUNextDay());


            Console.WriteLine($"Delivery Method                 $ cost");
            Console.WriteLine($"--------------------------------------");
            foreach (IDeliveryDriver deliveryOption in deliveryOptions)
            {
                double rate = deliveryOption.CalculateRate(inputDistance, inputWeight);
                Console.WriteLine($"{deliveryOption}, ${rate}, ");
            }
            

           
               



        }
    }
}
