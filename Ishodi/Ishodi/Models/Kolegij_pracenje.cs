using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("kolegij_pracenje")]
    public class Kolegij_pracenje
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int pohadanje { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int ekperimentalni_rad { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int esej { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int kolokvij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int aktivnost { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int pismeni { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int istrazivanje { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int referat { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int seminar { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int prakticni { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int usmeni { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int projekt { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int kontinuirana { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int ostalo_opis_1_ects { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int ostalo_opis_2_ects { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ostalo_opis_1{ get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ostalo_opis_2 { get; set; }
    }
}