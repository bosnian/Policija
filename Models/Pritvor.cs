using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Pritvor
    {
        public int Id { get; set; }
        public int OsobaId { get; set; }
        public Osoba Osoba { get; set; }
        public int ZapisnikId { get; set; }
        public Zapisnici Zapisnici { get; set; }
        public DateTime DatumPritvora { get; set; }
        public DateTime DatumOtpusta { get; set; }

    }
}
