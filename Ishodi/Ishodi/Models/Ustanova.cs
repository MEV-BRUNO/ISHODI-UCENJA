using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Ustanova
    {
        [Required]
        public int id_ustanova { get; set;}
        [Required]
        public string naziv { get; set; }
        [Required]
        public string adresa { get; set; }
        [Required]
        public string grad { get; set; }

    }
}