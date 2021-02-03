using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Movies.Models
{
   //making the movie model class and assigning them data type and doing the getters and setters 
    public class movie
    {   
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
      
        public bool Edited { get; set; }
       
        public string LentTo { get; set; }
      
        public string Notes { get; set; }
    }
}
