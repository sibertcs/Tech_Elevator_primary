﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {

        /*
        11. Write an if statement that returns "Fizz" 
            if the parameter is 3 and returns an empty string for anything else.
            TOPIC: Conditional Logic
        */
        public string ReturnFizzIfThree(int number)
        {
            string retValue ;

            if (number == 3)
            {
                retValue = "Fizz";                 
            }
            else
            {
                retValue = ""; 
            }

            return retValue; 
        }
    }
}
