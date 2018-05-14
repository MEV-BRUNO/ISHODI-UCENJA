using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Kolegij_opterecenje
    {
        public int id_program { get; set; }
        public int id_kolegij { get; set; }
        public int sati { get; set; }
        public string naziv_opterecenja { get; set; }
    }
}