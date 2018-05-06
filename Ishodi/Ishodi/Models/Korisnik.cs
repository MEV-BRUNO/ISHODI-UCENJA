using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class Korisnik
    {
        public int id { get; set; }
        public string ime_prezime { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string vrsta_korisnika { get; set; }
        public string titula { get; set; }
        public string id_ustanove { get; set; }
        public string licenca { get; set; }
        public string aktivacijski_link { get; set; }
        public bool aktivan { get; set; }

    }
}