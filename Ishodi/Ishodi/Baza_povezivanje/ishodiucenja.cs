using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Ishodi.Models;

namespace Ishodi.Baza_povezivanje
{
    public class ishodiucenja : DbContext
    {

        public DbSet<Korisnik> korisnici { get; set; }
    }
}
