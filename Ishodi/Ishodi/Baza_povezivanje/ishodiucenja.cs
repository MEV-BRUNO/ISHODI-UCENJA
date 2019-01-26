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

        public DbSet<Ustanova> ustanova { get; set; }

        public DbSet<Studijski_program> studijskiProgram { get; set; }

        public DbSet<Arhiva> arhiva { get; set; }

        public DbSet<Kolegij> kolegij { get; set; }

        public DbSet<Program_kolegij> programKolegij { get; set; }

        public DbSet<Kolegij_nastavnik> kolegijNastavnik { get; set; }

        public DbSet<Kolegij_opce_info> kolegijeOpceInfo { get; set; }

        public DbSet<Kolegij_ishod> kolegijIshod { get; set; }

        public DbSet<Kolegij_teme> kolegijTeme { get; set; }

        public DbSet<Kolegij_vrsta_nastave> kolegijVrstaNastave { get; set; }

        public DbSet<Kolegij_pracenje> kolegijPracenje { get; set; }

        public DbSet<Kolegij_opterecenje> kolegijOpterecenje { get; set; }

        public DbSet<Kolegij_literatura> kolegijeLiteratura { get; set; }
    }
}
