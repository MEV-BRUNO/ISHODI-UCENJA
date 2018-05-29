using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_opterecenje
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int sati { get; set; }
        [Required]
        public string naziv_opterecenja { get; set; }
    }
}