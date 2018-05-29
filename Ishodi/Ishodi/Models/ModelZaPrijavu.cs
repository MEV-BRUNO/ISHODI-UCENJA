using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ishodi.Models
{
    public class ModelZaPrijavu
    {

        // ZA prijavu
        [Required(ErrorMessage = "Ime je obavezno polje!")]
        public string korisnickoime { get; set; }

        [Required(ErrorMessage = "Lozinka je obavezno polje!")]
        public string korisnickalozinka { get; set; }

        // Za registraciju
        [Required(ErrorMessage = "Ime je obavezno polje")]
        public string name { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno polje!")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Korisničko ime je obavezno polje!")]
        public string username { get; set; }

        [Required(ErrorMessage = "E-mail adresa je obavezno polje!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Pogrešna e-mail adresa")]
        public string email { get; set; }


        [Required(ErrorMessage = "Lozinka je obavezno polje!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Obavezno polje!")]
        public string repeatpassword { get; set; }


        // za zaboravljena lozinka

        [Required(ErrorMessage = "E-mail adresa je obavezno polje!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Pogrešna e-mail adresa")]
        public string vasaemailadresa { get; set; }






    }
}