using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTauranter.Models;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private RESTContext _restContext;
        public HomeController (RESTContext context)
        {
            _restContext = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/reviews")]
        public IActionResult Reviews()
        {
            // List<Review> AllReviews = _restContext.reviews.OrderByDescending(q => q.CreatedAt).ToList();
            return View(_restContext.reviews.OrderByDescending(q => q.CreatedAt).ToList());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Review model)
        {
            if (ModelState.IsValid)
            {
                Review newReview = new Review
                {
                    ReviewerName = model.ReviewerName,
                    RestaurantName = model.RestaurantName,
                    Comment = model.Comment,
                    Rating = model.Rating,
                    Visited = model.Visited,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _restContext.Add(newReview);
                _restContext.SaveChanges();
                return RedirectToAction("Reviews");
            }
            return View("Index");
        }
    }
}
