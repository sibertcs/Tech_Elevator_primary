using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            this.HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            if (HasTrailer)
            {
                return (distance * 0.020) + 1.00;
            }
            else
            {
                return (distance * 0.020);
            }
        }

        public override string ToString()
        {
            string car = "Car";
            if (HasTrailer)
            {
                car = "Car (with trailer)";
            }
            return car;
        }
    }
}
