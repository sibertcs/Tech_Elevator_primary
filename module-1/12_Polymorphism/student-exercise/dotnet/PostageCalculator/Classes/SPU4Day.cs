using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU4Day : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {

            {
                return Math.Round((weight / 16 * 0.0050) * distance, 2);


            }
        }
        public override string ToString()
        {
            return "SPU (4-Day Ground)";
        }
    }
}
