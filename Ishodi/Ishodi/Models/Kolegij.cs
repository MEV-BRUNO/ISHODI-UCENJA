using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij
    {
        [Required(ErrorMessage ="Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage ="Naziv je obavezno polje!")]
        public string naziv { get; set; }
        [Required(ErrorMessage ="Kratica je obavezno polje!")]
        public string kratica { get; set; }
        [Required(ErrorMessage ="Šifra je obavezno polje")]
        public string sifra { get; set; }

    }
}