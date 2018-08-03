using MVCProyect.Models.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProyect.ViewModels
{
    public class NewUserViewModel
    {
        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public User User { get; set; }
    }
}