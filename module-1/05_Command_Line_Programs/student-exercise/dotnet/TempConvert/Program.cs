using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //prompt user to enter a temperature

            Console.WriteLine("Please enter the temperature:");
            string strInputTemp = Console.ReadLine();
            int inputTemp = int.Parse(strInputTemp);
                
            
            double temperature = (double)inputTemp;

            //prompt user if value entered is not C or F

            Console.WriteLine("Is the temperature in (C)elsius, or (F)arenheit?");
            string tempType = Console.ReadLine();

            while (tempType != "F" && tempType != "C")
            {
                Console.WriteLine("Please enter a C for Celsius or F for Farenheit");
                tempType = Console.ReadLine();

            }

            Console.WriteLine(temperature + tempType + " is " + (int)GetTemperature(tempType, temperature) + GetType(tempType) + ".");
            Console.ReadLine();
            

        }public static double GetTemperature(string tempType, double temperature) //ConvertsTemp
            {
            double tempConversion = 0;
            if (tempType == "F")
            {
                tempConversion = (temperature - 32) / 1.8;

            }
            else if (tempType == "C")
            {
                tempConversion = (temperature * 1.8) + 32;
            }
            return tempConversion;

            }
        public static string GetType(string tempType) //ConvertsType
        {
            string typeConversion = " ";
            if (tempType == "F")
            {
                typeConversion = "C";
            }
            else if (tempType == "C")
            {
                typeConversion = "F";
            }
            return typeConversion;
        }
        
        

    }
            
            
}
