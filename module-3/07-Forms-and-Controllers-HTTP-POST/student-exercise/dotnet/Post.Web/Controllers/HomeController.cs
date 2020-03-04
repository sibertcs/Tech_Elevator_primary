using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAO dao;

        public HomeController(IReviewDAO reviewDAO)
        {
            this.dao = reviewDAO;
        }
        // GET: Home
        public ActionResult Index()
        {
            var allReviews = dao.GetAllReviews();
            return View(allReviews);
        }

        public ActionResult NewReview()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewReview(Review newReview)
        {
            dao.SaveReview(newReview);
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
