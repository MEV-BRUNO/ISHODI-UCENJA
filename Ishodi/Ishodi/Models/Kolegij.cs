using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij
    {
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        public string kratica { get; set; }
        [Required]
        public string sifra { get; set; }

    }
}