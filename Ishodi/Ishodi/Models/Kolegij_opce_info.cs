using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Kolegij_opce_info
    {
        public string id_program { get; set; }
        public string id_kolegij { get; set; }
        public string status_kolegija { get; set; }
        public int ECTS { get; set; }
        public string izvodenje_nastave { get; set; }
        public string cilj { get; set; }
        public string uvjeti_polaganja { get; set; }
        public string obaveza_studenta { get; set; }
        public string ocjenjivanje_vrednovaje { get; set; }
        public string pracenje_kvalitete { get; set; }
        public string pohadanje_nastave { get; set; }
        public string kontakt_nastavnik { get; set; }
        public string info { get; set; }
        public string radovi { get; set; }
        public string ostalo { get; set; }

    }
}