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
        [Display(Name ="Movie Name :")]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberStock { get; set; }

        public Genre NameType { get; set; }

        public enum Genre : byte
        {
            Comedy = 1,
            Action = 2,
            Family = 3,
            Romance = 4

        }

        public Movie()
        {

        }
    }
}