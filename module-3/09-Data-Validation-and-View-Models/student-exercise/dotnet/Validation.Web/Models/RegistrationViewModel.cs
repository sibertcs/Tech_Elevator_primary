using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Display(Name = "First Name")]
        [Required, StringLength(20, ErrorMessage = "You must enter a name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required, StringLength(20, ErrorMessage = "You must enter a name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Required]
        [Compare("Email", ErrorMessage = "Email addresses do not match")]
        public string ConfirmEmail { get; set; }

        [Required, StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Birthday")]
        [Required]
        public DateTime BirthDay { get; set; }

        [Display(Name = "# of Tickets")]
        [Required]
        [Range(1, 10, ErrorMessage = "You must enter a number between 1 and 10")]
        public int NumberOfTickets { get; set; }
    }
}