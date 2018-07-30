using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProyect.Models.POCOS
{
    public class User
    {

        public int UserId { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        public bool IsSuscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

    }
}