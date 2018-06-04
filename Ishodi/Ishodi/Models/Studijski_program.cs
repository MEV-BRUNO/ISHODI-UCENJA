using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ishodi.Models
{
    [Table("studijski_program")]


namespace Ishodi.Models
{

    public class Studijski_program
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_program { get; set; }
        [Required(ErrorMessage = "Naziv je obavezno polje!")]
        public string naziv { get; set; }
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_ustanova { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public int ak_godina { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string opis { get; set; }

    }
}