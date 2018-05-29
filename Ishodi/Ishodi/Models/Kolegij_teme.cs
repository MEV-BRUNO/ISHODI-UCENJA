using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_teme
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int red_broj { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string predavanje { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string vjezba { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string literatura { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_ishod { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int predavanje_sati { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int vjezbe_sati{ get; set; }
    }
}