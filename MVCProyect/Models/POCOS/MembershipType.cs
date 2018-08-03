using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProyect.Models.POCOS
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public short SignUpFree { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
                        
        public MembershipTypeName Name { get; set; }

        public enum MembershipTypeName : byte
        {
            Monthy=1,
            PayAsYouGo=2
        }

    }
}