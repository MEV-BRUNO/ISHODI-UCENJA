using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_ishod
    {
        [Required]
        public long id_ishod { get; set; }
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public int rb { get; set; }
        [Required]
        public string ishod { get; set; }
        [Required]
        public string razina { get; set; }

    }
}