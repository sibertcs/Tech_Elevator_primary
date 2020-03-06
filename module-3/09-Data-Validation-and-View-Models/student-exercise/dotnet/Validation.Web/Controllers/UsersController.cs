using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginConfirmation(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUserConfirmation(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewUser");
            }
            return View();
        }





        // GET: User/Register
        // Return the empty registration view

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        

        // GET: User/Login
        // Return the empty login view

        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)

        // GET: User/Confirmation
        // Return the confirmation view

    }
}