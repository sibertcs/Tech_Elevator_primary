using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forms.Web.Models
{
    public class CitySearchModel
    {
        [Display(Name ="Enter a country code")]
        public string CountryCode { get; set; }

        [Display(Name ="Enter a district:")]
        public string District { get; set; }
    }
}
