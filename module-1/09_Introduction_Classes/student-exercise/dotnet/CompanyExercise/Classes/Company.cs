using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; set; }

        public int NumberOfEmployees { get; set; }

        public decimal Revenue { get; set; }

        public decimal Expenses { get; set; }
       

        public string GetCompanySize()
        {
            string size = "";
            if (NumberOfEmployees < 50)
            {
                size = "small";
            }
            else if (NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
            {
                size = "medium";
            }
            else
            {
                size = "large";
            }
            return size;
            
        }
        public decimal GetProfit()
        {
            decimal profit = Revenue - Expenses;
            return profit;
        }
        public Company() { }
    }

}
