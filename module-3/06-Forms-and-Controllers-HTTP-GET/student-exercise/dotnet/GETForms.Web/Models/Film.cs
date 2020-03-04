using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class Film
    {
        /// <summary>
        /// The film's title.
        /// </summary>
        [Display(Name = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// The film's description.
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// The film's release year.
        /// </summary>
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }

        /// <summary>
        /// The film's length.
        /// </summary>
        [Display(Name = "Length")]
        public int Length { get; set; }

        /// <summary>
        /// The film's rating.
        /// </summary>
        [Display(Name = "Rating")]
        public string Rating { get; set; }
    }
}
