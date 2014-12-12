using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Dezurstvo
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public Zaposlenici Zaposlenik { get; set; }
        public int DogadjajId { get; set; }
        public Dogadjaji Dogadjaj { get; set; }
        public string Uloga { get; set; }
    }
}
