using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //prompt the user for space delmited numbers
            //convert them each to binary 
            //spit them back out on the screen 

            string nums = "1 4 8 9";
            string[] strNumsArray = nums.Split(" ");
            int[] numsAsInts = new int[strNumsArray.Length];
            for (int i = 0; i < strNumsArray.Length; i++)
            {
                numsAsInts[i] = int.Parse(strNumsArray[i]);
                string binary = ConvertNumberToBinary(numsAsInts[i]);
                Console.WriteLine(numsAsInts[i] + " as binary is " + binary);
            }

            WriteArrayToConsole(strNumsArray);

        }

        private static void WriteArrayToConsole(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
        }

        private static string ConvertNumberToBinary(int base10)
        {
            string binary = "";
            while (base10 > 0)
            {
                binary = (base10 % 2) + binary;
                base10 = base10 / 2;
            }

            return binary;
        }
    }
}
