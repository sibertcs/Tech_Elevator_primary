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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            //if strength length is zero, return string

            //if str length is one, return string

            //if str length is two, return string

            if (str.Length < 3)
            {
                return str;
            }
            char strBegin = str[0];
            char strEnd = str[str.Length - 1];
            string strMid = str.Substring(1, str.Length - 2).Replace("x", "");

            //strMid = strMid.Replace("x", "");

            return strBegin + strMid + strEnd;

           
        }
    }
}
