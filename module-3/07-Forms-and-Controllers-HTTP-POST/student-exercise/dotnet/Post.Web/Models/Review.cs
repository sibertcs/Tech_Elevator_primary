using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        [Display(Name = "Enter your name:")]
        public string UserName { get; set; }

        [Display(Name = "How many stars:")]
        public int Rating { get; set; }

        [Display(Name = "Provide a title:")]
        public string ReviewTitle { get; set; }

        [Display(Name = "Review:")]
        public string ReviewContent { get; set; }

        public DateTime ReviewDate { get; set; }
       
    }
}
