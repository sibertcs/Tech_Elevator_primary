using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceFirstClass : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            double cost = 0;

            if (weight <= 2)
            {
                cost = 0.035 * distance;
            }
            else if (weight <= 8)
            {
                cost = 0.040 * distance;
            }
            else if (weight <= 15)
            {
                cost = 0.047 * distance;
            }
            else if (weight <= 48)
            {
                cost = 0.195 * distance;
            }
            else if (weight <= 128)
            {
                cost = 0.450 * distance;
            }
            else
            {
                cost = 0.500 * distance;
            }
            return Math.Round(cost, 2);

        }
        public override string ToString()
        {
            return "Postal Service (1st Class)";
        }
    }
}
