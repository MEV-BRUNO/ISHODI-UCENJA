using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ishodi.Models
{
    public class Kolegij_vrsta_nastave
    {
        [Required]
        public int id_program { get; set; }
        [Required]
        public int id_kolegij { get; set; }
        [Required]
        public string predavanje { get; set; }
        [Required]
        public string seminari { get; set; }
        [Required]
        public string vjezbe { get; set; }
        [Required]
        public string na_daljinu { get; set; }
        [Required]
        public string mjesovito { get; set; }
        [Required]
        public string terenska { get; set; }
        [Required]
        public string samostalni_rad { get; set; }
        [Required]
        public string multimedija { get; set; }
        [Required]
        public string laboratorij { get; set; }
        [Required]
        public string mentor { get; set; }
        [Required]
        public string ostalo { get; set; }
        [Required]
        public string ostalo_selekt { get; set; }
        [Required]
        public string komentar { get; set; }
        
    }
}