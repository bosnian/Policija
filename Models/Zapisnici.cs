using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Policija.Models
{
    class Zapisnici
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public Zaposlenici Zaposlenik { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
