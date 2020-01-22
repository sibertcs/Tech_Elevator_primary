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
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            string splosion = "";
            //for loop through the string
            //at index 0, print once
            //at index 1, print twice
            //at index 2, print 3x
            //append str[i] onto the end splosion

            for (int i = 0; i < str.Length + 1; i++)
            {
                
                splosion += str.Substring(0, i);
            }
            return splosion;






            /*
            string modifiedString = "";
            for (int i = 0; i <= str.Length; i++)
            {
                
                str = str.Substring(0, str.Length - 1);
            }
                modifiedString = str + modifiedString; 
                
            return modifiedString; */
        }
    }
}
