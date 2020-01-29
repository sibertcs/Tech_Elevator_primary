using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck (int numberOfAxles) 
        {
            this.NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            if (NumberOfAxles == 4)
            {
                return distance * 0.040;
            }
            else if (NumberOfAxles == 6)
            {
                return distance * 0.045;
            }
            else 
            {
                return distance * 0.048;
            }
        }

        public override string ToString()
        {
            string truck = "";
            if (NumberOfAxles == 4)
            {
                truck = "Truck (4 Axles)";
            }
            else if (NumberOfAxles == 6)
            {
                truck = "Truck (6 Axles)";
            }
            else
            {
                truck = "Truck (8 Axles)";
            }
            return truck;

        }
    }
}
