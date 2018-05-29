using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Arhiva
    {
        [Required]
        public int id_arhive { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        public string datoteka { get; set; }

    }
}