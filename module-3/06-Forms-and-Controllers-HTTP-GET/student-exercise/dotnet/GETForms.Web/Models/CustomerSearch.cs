using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearch
    {
        public string Name { get; set; }

        public string SortType { get; set; }

        public static List<SelectListItem> OrderBy = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Last Name", Value = "last_name" },
            new SelectListItem() { Text = "First Name", Value = "first_name" },
            new SelectListItem() { Text = "Email", Value = "email" },
            new SelectListItem() { Text = "Status", Value = "active" },
            
        };

    }
}
