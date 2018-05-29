using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Studijski_program
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        public int id_ustanova { get; set; }
        [Required]
        public int ak_godina { get; set; }
        [Required]
        public string opis { get; set; }

    }
}