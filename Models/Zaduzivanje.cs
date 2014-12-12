using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Zaduzivanje
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public Zaposlenici Zaposlenik { get; set; }
        public int? AutoId { get; set; }
        public Auta Auto { get; set; }
        public int? OpremaId { get; set; }
        public Oprema Oprema { get; set; }
        public DateTime DatumZaduzivanja { get; set; }
        public DateTime DatumRazduzivanja { get; set; }
    }
}
