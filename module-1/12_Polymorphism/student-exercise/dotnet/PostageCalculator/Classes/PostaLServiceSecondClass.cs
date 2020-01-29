using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceSecondClass : IDeliveryDriver
    {
     
        public double CalculateRate(int distance, double weight)
        { 
            double cost = 0;

            if (weight <= 2)
            {
                cost = 0.0035 * distance;
            }
            else if (weight <= 8)
            {
                cost = 0.0040 * distance;
            }
            else if (weight <= 15)
            {
                cost = 0.0047 * distance;
            }
            else if (weight <= 48)
            {
                cost = 0.0195 * distance;
            }
            else if (weight <= 128)
            {
                cost = 0.0450 * distance;
            }
            else
            {
                cost = 0.0500 * distance;
            }
            return Math.Round(cost, 2);
        }
        public override string ToString()
        {
            return "Postal Service (2nd Class)";
        }


    }
}
