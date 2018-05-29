using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_opterecenje
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int sati { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string naziv_opterecenja { get; set; }
    }
}