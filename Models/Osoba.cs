using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Mjesto { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumUnosa { get; set; }

    }
}
