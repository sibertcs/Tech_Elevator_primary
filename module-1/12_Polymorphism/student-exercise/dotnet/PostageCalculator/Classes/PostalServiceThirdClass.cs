using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceThirdClass : IDeliveryDriver
    {
        
        public double CalculateRate(int distance, double weight)
        { 
            double cost = 0;

            if (weight <= 2)
            {
                cost = 0.0020 * distance;
            }
            else if (weight <= 8)
            {
                cost = 0.0022 * distance;
            }
            else if (weight <= 15)
            {
                cost = 0.0024 * distance;
            }
            else if (weight <= 48)
            {
                cost = 0.0150 * distance;
            }
            else if (weight <= 128)
            {
                cost = 0.0160 * distance;
            }
            else
            {
                cost = 0.0170 * distance;
            }
            return Math.Round(cost, 2);
        }
        public override string ToString()
        {
            return "Postal Service (3rd Class)";
        }

    }
}
