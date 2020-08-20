using MovieCustomerMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMvcApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        // GET: Movies
        public MoviesController()
        {
            _context = new ApplicationDbContext();

        }
        public ActionResult Index()

        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}