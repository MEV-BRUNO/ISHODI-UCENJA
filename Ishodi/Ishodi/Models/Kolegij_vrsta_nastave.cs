using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("kolegij_vrsta_nastave")]
    public class Kolegij_vrsta_nastave
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_kolegij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string predavanje { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string seminari { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string vjezbe { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string na_daljinu { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string mjesovito { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string terenska { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string samostalni_rad { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string multimedija { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string laboratorij { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string mentor { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ostalo { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string ostalo_selekt { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string komentar { get; set; }
        
    }
}