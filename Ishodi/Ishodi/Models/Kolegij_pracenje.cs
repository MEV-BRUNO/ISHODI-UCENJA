using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Kolegij_pracenje
    {
        public int id_program { get; set; }
        public int id_kolegij { get; set; }
        public int pohadanje { get; set; }
        public int ekperimentalni_rad { get; set; }
        public int esej { get; set; }
        public int kolokvij { get; set; }
        public int aktivnost { get; set; }
        public int pismeni { get; set; }
        public int istrazivanje { get; set; }
        public int referat { get; set; }
        public int seminar { get; set; }
        public int prakticni { get; set; }
        public int usmeni { get; set; }
        public int projekt { get; set; }
        public int kontinuirana { get; set; }
        public int ostalo_opis_1_ects { get; set; }
        public int ostalo_opis_2_ects { get; set; }
        public string ostalo_opis_1{ get; set; }
        public string ostalo_opis_2 { get; set; }
    }
}