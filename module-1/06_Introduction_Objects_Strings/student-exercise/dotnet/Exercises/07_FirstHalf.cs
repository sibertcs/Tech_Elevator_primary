using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
         FirstHalf("WooHoo") → "Woo"
         FirstHalf("HelloThere") → "Hello"
         FirstHalf("abcdef") → "abc"
         */
        public string FirstHalf(string str)
        {
            int wordLength = str.Length;
            string firstHalfOfWord = str.Substring(0, wordLength / 2);
            return firstHalfOfWord;
        }
    }
}
