using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("korisnik")]


    public class Korisnik
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id { get; set; }
        [Required(ErrorMessage = "Ime je obavezno polje!")]
        public string ime_prezime { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Pogrešna e-mail adresa")]
        public string email { get; set; }
        [Required(ErrorMessage ="Obavezno polje!")]
        public string lozinka { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string vrsta_korisnika { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string titula { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public long id_ustanove { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        [DataType(DataType.DateTime)]
        public DateTime licenca { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string aktivacijski_link { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public bool aktivan { get; set; }

    }
}