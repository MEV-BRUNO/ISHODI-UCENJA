using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

    


namespace Ishodi.Models
{
    [Table("ustanova")]
    public class Ustanova
    {
        [Required(ErrorMessage = "Id je obavezno polje!")]
        public long id_ustanova { get; set;}

        [Required(ErrorMessage = "Naziv je obavezno polje!")]  

        

        public string naziv { get; set; }
        [Required(ErrorMessage = "Adresa je obavezno polje!")]
        public string adresa { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        public string grad { get; set; }

    }
}