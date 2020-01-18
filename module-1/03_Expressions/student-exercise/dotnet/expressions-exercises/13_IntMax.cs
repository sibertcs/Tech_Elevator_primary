using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given three int values, a b c, return the largest.
        IntMax(1, 2, 3) → 3
        IntMax(1, 3, 2) → 3
        IntMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            int largestNum;
            if(a > b && a > c)
            {
                largestNum = a;
            }
            else if (b > a && b > c)
            {
                largestNum = b;
            }
            else
                largestNum = c;
            return largestNum;
        }

    }
}
