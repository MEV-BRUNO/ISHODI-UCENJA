using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("kolegij literatura")]
    public class Kolegij_literatura
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Naziv je obavezno polje!")]
        public string naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string vrsta { get; set; }
	}
}
