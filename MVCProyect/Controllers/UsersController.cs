using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProyect.Models;

namespace MVCProyect.Controllers
{
    public class UsersController : Controller
    {
        private MvcDbContext applicationContex;

        public UsersController()
        {
            applicationContex = new MvcDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            applicationContex.Dispose();
        }

        // GET: Users
        public ActionResult UserList()
        {

            var users = applicationContex.Users.Include(c => c.MembershipType).ToList();

            return View(users);
        }

        public ActionResult Details(int id)
        {
            var user = applicationContex.Users.SingleOrDefault(c=> c.Id == id);
            if (user.Equals(null))
            {
                return HttpNotFound();
            }

            return View(user);

        }
    }
}