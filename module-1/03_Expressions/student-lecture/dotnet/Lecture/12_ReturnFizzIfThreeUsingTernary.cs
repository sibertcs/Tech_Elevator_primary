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
        12. Now write the above using the Ternary operator ?:
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            //(some condition) ? <use this if true> : <use this if false>;
            return (number == 3) ? "Fizz" : "";
            
        }
    }
}
