using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("kolegij ishod")]

    public class Kolegij_ishod
    {
        [Required(ErrorMessage ="Id je obavezno polje!")]
        public long id_ishod { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage ="Obavezno polje!")]
        public int rb { get; set; }
        [Required(ErrorMessage ="Obavezno polje!")]
        public string ishod { get; set; }
        [Required(ErrorMessage ="Obavezno polje!")]
        public string razina { get; set; }

    }
}