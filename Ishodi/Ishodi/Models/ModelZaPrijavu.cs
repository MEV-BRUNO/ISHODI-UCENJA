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
        [Required(ErrorMessage = "The username is required")]
        public string korisnickoime { get; set; }

        [Required(ErrorMessage = "The password is required")]
        public string korisnickalozinka { get; set; }

        // Za registraciju
        [Required(ErrorMessage = "The name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "The surname is required")]
        public string surname { get; set; }

        [Required(ErrorMessage = "The username is required")]
        public string username { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }


        [Required(ErrorMessage = "The password is required")]
        public string password { get; set; }

        [Required(ErrorMessage = "The repeat password is required")]
        public string repeatpassword { get; set; }


        // za zaboravljena lozinka

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string vasaemailadresa { get; set; }






    }
}