using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //fib sequence 1,1,2,3,5,8... you get the next item by adding two previous items

            //prompt the user for  a number
            int userInput = 50;
            //generate and print sequence up to that number

            int secondToLastItem=1;
            int lastItem=1;
            int thisItem=2; 

            for (; thisItem<userInput;thisItem = secondToLastItem+lastItem )
            {
                Console.WriteLine(thisItem);
                secondToLastItem = lastItem;
                lastItem = thisItem;
            }

            do
            {
                thisItem = secondToLastItem + lastItem;
                Console.WriteLine(thisItem);
                secondToLastItem = lastItem;
                lastItem = thisItem; 

            }
            while (thisItem < userInput);


        }
    }
}
