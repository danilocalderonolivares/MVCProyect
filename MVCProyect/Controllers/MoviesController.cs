using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProyect.Models;
using MVCProyect.Models.POCOS;

namespace MVCProyect.Controllers
{
    public class MoviesController : Controller
    {
        private MvcDbContext applicationDbContext;

        public MoviesController()
        {
            applicationDbContext = new MvcDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            applicationDbContext.Dispose();
        }

        // GET: Movies/Test
        public ActionResult MovieList()
        {
            var movies = applicationDbContext.Movies.ToList();
            if (movies.Equals(null))
            {
                return HttpNotFound("There is not movies registered");
            }
            return View(movies);
        }

        public ActionResult MovieDetail(int id)
        {
            var movie = applicationDbContext.Movies.SingleOrDefault(m=> m.MovieId == id);
            if (movie.Equals(null))
            {
                return HttpNotFound("This was not found");
            }

            return View(movie);
        }
    }
}