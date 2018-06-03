using Ishodi.Baza_povezivanje;
using Ishodi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Ishodi.Controllers
{
    public class LoginController : Controller
    {
        private ishodiucenja baza = new ishodiucenja();

        public ActionResult lozinka()
        {


            return View();
        }
    }
}


        //[HttpGet]
        //public ActionResult FormaZaRegistraciju()
        //{
        //}