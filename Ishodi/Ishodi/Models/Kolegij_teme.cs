using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_teme
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int red_broj { get; set; }
        [Required]
        public string predavanje { get; set; }
        [Required]
        public string vjezba { get; set; }
        [Required]
        public string literatura { get; set; }
        [Required]
        public int id_ishod { get; set; }
        [Required]
        public int predavanje_sati { get; set; }
        [Required]
        public int vjezbe_sati{ get; set; }
    }
}