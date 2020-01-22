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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            bool isX = false;
            
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('x'))
                {
                    if(str[i].Equals('x') && str[i + 1].Equals('x'))
                    {
                        isX = true;
                    }
                    break;
                }
            }

            return isX;
        }

    }
}
