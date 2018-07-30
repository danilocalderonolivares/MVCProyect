using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProyect.Models;

namespace MVCProyect.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserList()
        {
            MvcDbContext dbContext = new MvcDbContext();
            var users = dbContext.Users.ToList();

            return View(users);
        }
    }
}