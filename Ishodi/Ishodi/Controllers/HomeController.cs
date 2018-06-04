using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ishodi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FormaZaPrijavu()
        {
            ViewBag.Message = "FormaZaPrijavu";
            return View();
        }


        public ActionResult FormaZaRegistraciju()
        {
            ViewBag.Message = "FormaZaRegistraciju";

            return View();
        }

        public ActionResult FormaZaZabLozinku()
        {
            ViewBag.Message = "FormaZaZabLozinku";

            return View();
        }


        public ActionResult Studijskiprogrami()
        {
            ViewBag.Message = "Studijskiprogrami";
            return View();
        }

        public ActionResult KolegijiStudijskihPrograma()
        {
            ViewBag.Message = "KolegijiStudijskihPrograma";

            return View();
        }
    }
}