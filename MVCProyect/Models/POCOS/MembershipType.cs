using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProyect.Models.POCOS
{
    public class MembershipType
    {
        public int MembershipTypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        public short SignUpFree { get; set; }
        [Required]
        public byte DurationInMonth { get; set; }

        [Required]
        public int DiscontRate { get; set; }

       
        public enum MembershipTypeValidation : byte
        {
            Unknow,
            PayAsYouGo
        }

    }
}