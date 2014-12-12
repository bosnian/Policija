using Policija.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.DAL
{
    internal class MojContext : DbContext
    {

        public MojContext()
            : base("MojConnectionString")
        {

        }

        public DbSet<Oprema> Oprema { get; set; }
        public DbSet<Auta> Auta { get; set; }
        public DbSet<Dezurstvo> Dezurstvo { get; set; }
        public DbSet<Dogadjaji> Dogadjaji { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Pritvor> Pritvor { get; set; }
        public DbSet<UlogeZaposlenika> UlogeZaposlenika { get; set; }
        public DbSet<VrsteDogadjaja> VrsteDogadjaja { get; set; }
        public DbSet<Zaduzivanje> Zaduzivanje { get; set; }
        public DbSet<Zapisnici> Zapisnici { get; set; }
        public DbSet<Zaposlenici> Zaposlenici { get; set; }

    }
}
