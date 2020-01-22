﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of Integers, return a List that contains the same Integers (as Strings). Except any multiple of 3
         should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
         and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
         ** INTERVIEW QUESTION **

         FizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
         FizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "Fizz"]
         FizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]

         HINT: To convert an integer x to a string you can call x.ToString() in your code (e.g. if x = 1 then x.ToString() equals "1")
         */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            List<string> listOfNumsAsStrings = new List<string>();
            List<int> listOfNums = new List<int>();
            listOfNums.AddRange(integerArray);

            foreach (int item in listOfNums)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    string itemAsString = item.ToString();
                    itemAsString = "FizzBuzz";
                    listOfNumsAsStrings.Add(itemAsString);
                }
                else if (item % 3 == 0)
                {
                    string itemAsString = item.ToString();
                    itemAsString = "Fizz";
                    listOfNumsAsStrings.Add(itemAsString);
                }
                else if (item % 5 == 0)
                {
                    string itemAsString = item.ToString();
                    itemAsString = "Buzz";
                    listOfNumsAsStrings.Add(itemAsString);
                }
                else
                {
                    string itemAsString = item.ToString();                  
                    listOfNumsAsStrings.Add(itemAsString);
                }
               
            }           
            return listOfNumsAsStrings;

            

        }

    }
}
