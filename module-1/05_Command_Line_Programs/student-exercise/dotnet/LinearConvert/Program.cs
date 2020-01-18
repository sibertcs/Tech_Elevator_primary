using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length:");
            string strLengthInput = Console.ReadLine();
            int lengthInput = int.Parse(strLengthInput);
            double lengthInputAsDouble = (double)lengthInput;

            //prompt user if value entered is not C or F

            Console.WriteLine("Is the measurement in (m)eters or (f)eet?");
            string lengthUnit = Console.ReadLine();

            if (lengthUnit != "f" && lengthUnit != "m")
            {
                Console.WriteLine("Please enter a m for meter or f for feet");
                lengthUnit = Console.ReadLine();

            }

            Console.WriteLine(lengthInputAsDouble + lengthUnit + " is " + (double)GetLengthConversion(lengthUnit, lengthInputAsDouble) + GetUnitConvsersion(lengthUnit) + ".");

        }

        public static double GetLengthConversion(string lengthUnit, double lengthInputAsDouble) //ConvertsTemp
        {
            double lengthConversion = 0;
            if (lengthUnit == "m")
            {
                lengthConversion = lengthInputAsDouble * 3.2808399;

            }
            else if (lengthUnit == "f")
            {
                lengthConversion = lengthInputAsDouble * 0.3048; 
            }
            return lengthConversion;

        }
        public static string GetUnitConvsersion(string lengthUnit) // ConvertsType
        {
            string unitConversion = " ";
            if (lengthUnit == "m")
            {
                unitConversion = "f";
            }
            else if (lengthUnit == "f")
            {
                unitConversion = "m";
            }
            return unitConversion;
        }
    }
}
