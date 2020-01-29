using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUNextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            return Math.Round((weight / 16 * 0.075) * distance, 2);
        }
        public override string ToString()
        {
            return "SPU (Next Day)";
        }
    }
}
