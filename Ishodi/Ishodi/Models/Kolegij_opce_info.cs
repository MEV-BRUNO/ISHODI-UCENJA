using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("kolegij opce info")]
    public class Kolegij_opce_info
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Status je obavezno polje!")]
        public string status_kolegija { get; set; }
        [Required(ErrorMessage = "ECTS je obavezno polje!")]
        public int ECTS { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string izvodenje_nastave { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string cilj { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string uvjeti_polaganja { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string obaveza_studenta { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ocjenjivanje_vrednovaje { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string pracenje_kvalitete { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string pohadanje_nastave { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string kontakt_nastavnik { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string info { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string radovi { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ostalo { get; set; }

    }
}