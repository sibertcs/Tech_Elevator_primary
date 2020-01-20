using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a series of decimal values (separated by spaces): ");
            string strBase10 = Console.ReadLine();
            string[] strBase10NumbersSplit = strBase10.Split(' ');
            int[] intBase10Numbers = Array.ConvertAll(strBase10NumbersSplit,int.Parse);

            for (int i = 0; i < intBase10Numbers.Length; i++)
            {
                Console.WriteLine(intBase10Numbers[i] + " in binary is " + ConvertNumberToBinary(intBase10Numbers[i]));
            }

            Console.ReadLine();




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
