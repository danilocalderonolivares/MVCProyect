using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProyect.Models.POCOS
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Movie()
        {

        }
    }
}