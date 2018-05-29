using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Korisnik
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string ime_prezime { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string lozinka { get; set; }
        [Required]
        public string vrsta_korisnika { get; set; }
        [Required]
        public string titula { get; set; }
        [Required]
        public int id_ustanove { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime licenca { get; set; }
        [Required]
        public string aktivacijski_link { get; set; }
        [Required]
        public bool aktivan { get; set; }

    }
}