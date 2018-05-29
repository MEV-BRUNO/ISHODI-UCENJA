using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_opce_info
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int status_kolegija { get; set; }
        [Required]
        public int ECTS { get; set; }
        [Required]
        public string izvodenje_nastave { get; set; }
        [Required]
        public string cilj { get; set; }
        [Required]
        public string uvjeti_polaganja { get; set; }
        [Required]
        public string obaveza_studenta { get; set; }
        [Required]
        public string ocjenjivanje_vrednovaje { get; set; }
        [Required]
        public string pracenje_kvalitete { get; set; }
        [Required]
        public string pohadanje_nastave { get; set; }
        [Required]
        public string kontakt_nastavnik { get; set; }
        [Required]
        public string info { get; set; }
        [Required]
        public string radovi { get; set; }
        [Required]
        public string ostalo { get; set; }

    }
}