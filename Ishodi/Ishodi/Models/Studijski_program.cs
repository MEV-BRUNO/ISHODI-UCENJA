using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Studijski_program
    {
        public string id_program { get; set; }
        public string naziv { get; set; }
        public string id_ustanova { get; set; }
        public int ak_godina { get; set; }
        public string opis { get; set; }

    }
}