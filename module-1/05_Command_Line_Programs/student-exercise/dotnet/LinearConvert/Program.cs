using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length:");
            string strLengthInput = Console.ReadLine();
            double lengthInput = double.Parse(strLengthInput);
           

            //prompt user if value entered is not C or F

            Console.WriteLine("Is the measurement in (m)eters or (f)eet?");
            string lengthUnit = Console.ReadLine();
            while (lengthUnit != "f" && lengthUnit != "m")
            {
                Console.WriteLine("Please enter m for meter or f for feet");
                lengthUnit = Console.ReadLine();

            }
            
            Console.WriteLine(lengthInput + lengthUnit + " is " + Math.Floor((double)GetLengthConversion(lengthUnit, lengthInput)) + GetUnitConvsersion(lengthUnit) + ".");

        }

        public static double GetLengthConversion(string lengthUnit, double lengthInput) //ConvertsTemp
        {
            double lengthConversion = 0;
            if (lengthUnit == "m")
            {
                lengthConversion = lengthInput * 3.2808399;

            }
            else if (lengthUnit == "f")
            {
                lengthConversion = lengthInput * 0.3048; 
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
