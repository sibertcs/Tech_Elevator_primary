using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUNextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            weight /= 16;
            return Math.Round((weight * 0.075) * distance, 2);
        }
        public override string ToString()
        {
            return "SPU (Next Day)";
        }
    }
}
