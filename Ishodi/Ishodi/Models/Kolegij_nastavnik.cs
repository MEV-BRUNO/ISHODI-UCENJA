using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_nastavnik
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int id_korisnik { get; set; }


    }
}