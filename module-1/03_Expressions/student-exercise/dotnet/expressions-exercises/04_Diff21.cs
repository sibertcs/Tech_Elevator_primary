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
         Given an int n, return the absolute difference between n and 21, except return double the absolute
         difference if n is over 21.
         Diff21(19) → 2
         Diff21(10) → 11
         Diff21(21) → 0
         */
        public int Diff21(int n)
        {
            if (n <= 21)
            {
                return 21 - n;
            }
            return (n - 21) * 2; 
     
           
         
        }
    }
}
