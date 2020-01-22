using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci Number:");
            string strNumberInput = Console.ReadLine();
            int numberInput = int.Parse(strNumberInput);
                    
            int i = 2;
            int val1 = 0; 
            int val2 = 1;

            while (i <= numberInput)
            {
                if (val2 >= numberInput)
                {
                    Console.Write(val1 + ", ");
                    break;
                }
                Console.Write(val1 + ", ");
                int sumOfTwoBefore = val1 + val2;
                val1 = val2;
                val2 = sumOfTwoBefore;
                ++i;
                
                
            }


            
            

           


            
            

            
            

            
                
                
            
            
        }
    }
}
