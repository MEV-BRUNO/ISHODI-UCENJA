using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("arhiva")]

    public class Arhiva
    {
        [Required(ErrorMessage ="Id je obavezno polje!")]
        public long id_arhive { get; set; }
        [Required(ErrorMessage ="Naziv je obavezno polje!")]
        public string naziv { get; set; }
        [Required(ErrorMessage ="Obavezno polje!")]
        public string datoteka { get; set; }

    }
}