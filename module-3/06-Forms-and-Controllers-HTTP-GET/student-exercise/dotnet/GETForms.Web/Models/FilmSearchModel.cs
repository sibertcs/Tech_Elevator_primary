using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearchModel
    {
        public FilmSearchModel()
        {
            MaxLength = 1000;
        }

        [Display(Name = "Minimum Length:")]
        public int MinLength { get; set; }

        [Display(Name = "Maximum Length:")]
        public int MaxLength { get; set; }

        public string Genre { get; set; }


        
       

        
    }
}
