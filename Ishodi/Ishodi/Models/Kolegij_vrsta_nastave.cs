using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Kolegij_vrsta_nastave
    {
        public int id_program { get; set; }
        public int id_kolegij { get; set; }
        public string predavanje { get; set; }
        public string seminari { get; set; }
        public string vjezbe { get; set; }
        public string na_daljinu { get; set; }
        public string mjesovito { get; set; }
        public string terenska { get; set; }
        public string samostalni_rad { get; set; }
        public string multimedija { get; set; }
        public string laboratorij { get; set; }
        public string mentor { get; set; }
        public string ostalo { get; set; }
        public string ostalo_selekt { get; set; }
        public string komentar { get; set; }
        
    }
}