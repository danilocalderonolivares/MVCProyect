using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProyect.Models.POCOS;

namespace MVCProyect.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Test
        public ActionResult Test()
        {

            var movie = new Movie 
            {
                Name="Test"
            };
            return View(movie);
        }
    }
}