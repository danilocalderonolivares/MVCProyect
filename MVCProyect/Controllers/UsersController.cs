using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProyect.Models;
using MVCProyect.Models.POCOS;
using MVCProyect.ViewModels;

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
            var user = applicationContex.Users
                .Include(m => m.MembershipType)
                .SingleOrDefault(c => c.Id == id);
                

            if (user.Equals(null))
            {
                return HttpNotFound("This user does not exist");
            }

         
            return View(user);

        }

        public ActionResult UserForm()
        {
            var membershiptypes = applicationContex.membershipTypes.ToList();
            var viewModel =  new NewUserViewModel
            {
               membershipTypes = membershiptypes
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult SaveUser(User user)
        {
            applicationContex.Users.Add(user);
            applicationContex.SaveChanges();
            return RedirectToAction("UserList", "Users");
        }
        
    }
}