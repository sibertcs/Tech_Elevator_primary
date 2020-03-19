using System;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String data = String.Format("{0,-20} {1,-20} {2,-10} {3, -10} \n",
"Title", "Publisher", "Price", "Year");
            Console.WriteLine(data);
        }
    }
}
