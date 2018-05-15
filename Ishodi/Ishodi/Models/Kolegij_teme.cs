using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Kolegij_teme
    {
        public int id_program { get; set; }
        public int id_kolegij { get; set; }
        public int red_broj { get; set; }
        public string predavanje { get; set; }
        public string vjezba { get; set; }
        public string literatura { get; set; }
        public int id_ishod { get; set; }
        public int predavanje_sati { get; set; }
        public int vjezbe_sati{ get; set; }
    }
}