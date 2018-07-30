using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCProyect.Models.POCOS;

namespace MVCProyect.Models
{
    public class MvcDbContext :IdentityDbContext<ApplicationUser>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType>  membershipTypes { get; set; }

        public MvcDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MvcDbContext Create()
        {
            return new MvcDbContext();
        }
    }
}