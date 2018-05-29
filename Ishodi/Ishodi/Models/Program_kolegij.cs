using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Program_kolegij
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int semestar { get; set; }


    }
}