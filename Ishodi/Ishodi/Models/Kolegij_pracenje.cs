using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_pracenje
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int pohadanje { get; set; }
        [Required]
        public int ekperimentalni_rad { get; set; }
        [Required]
        public int esej { get; set; }
        [Required]
        public int kolokvij { get; set; }
        [Required]
        public int aktivnost { get; set; }
        [Required]
        public int pismeni { get; set; }
        [Required]
        public int istrazivanje { get; set; }
        [Required]
        public int referat { get; set; }
        [Required]
        public int seminar { get; set; }
        [Required]
        public int prakticni { get; set; }
        [Required]
        public int usmeni { get; set; }
        [Required]
        public int projekt { get; set; }
        [Required]
        public int kontinuirana { get; set; }
        [Required]
        public int ostalo_opis_1_ects { get; set; }
        [Required]
        public int ostalo_opis_2_ects { get; set; }
        [Required]
        public string ostalo_opis_1{ get; set; }
        [Required]
        public string ostalo_opis_2 { get; set; }
    }
}