using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Dogadjaji
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int VrstaDogadjajaId { get; set; }
        public VrsteDogadjaja VrstaDogadjaja { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
    }
}
