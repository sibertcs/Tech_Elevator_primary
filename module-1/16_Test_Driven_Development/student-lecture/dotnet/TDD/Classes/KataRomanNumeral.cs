using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Classes
{
    public class RomanNUMERAL
    {
        public string romanNumeral(int n)
        {
            string result = "";

            while (n >= 1000)
            {
                result += "M";
                n -= 1000;
            }
            while (n >= 900)
            {
                result += "CM";
                n -= 900;
            }
            while (n >= 500)
            {
                result += "D";
                n -= 500;
            }
            while (n >= 400)
            {
                result += "CD";
                n -= 400;
            }
            while (n >= 100)
            {
                result += "C";
                n -= 100;
            }
            while (n >= 90)
            {
                result += "XC";
                n -= 90;
            }
            while (n >= 50)
            {
                result += "L";
                n -= 50;
            }
            while (n >= 40)
            {
                result += "XL";
                n -= 40;
            }
            while (n >= 10)
            {
                result += "X";
                n -= 10;
            }
            while (n == 9)
            {
                result += "IX";
                n -= 9;
                break;
            }
            while (n >= 5)
            {
                result += "V";
                n -= 5;
            }
            while (n == 4)
            {
                result += "IV";
                n -= 4;
                break;
            }
            while (n >= 1)
            {
                result += "I";
                n -= 1;
            }
            return result;

        }
    
    }
}