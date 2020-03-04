using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAO dao;

        public CustomersController(ICustomerDAO customerDAO)
        {
            this.dao = customerDAO;
        }

        public IActionResult CustomerSearch()
        {
            return View();
        }

        public IActionResult CustomerSearchResult(CustomerSearch model)
        {
            var customers = dao.SearchForCustomers(model.Name, model.SortType);
            return View(customers);

        }


    }
}