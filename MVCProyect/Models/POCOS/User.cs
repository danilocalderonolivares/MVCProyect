using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProyect.Models.POCOS
{
    public class User 
    {

        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType  { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }


       
    }
}