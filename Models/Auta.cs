using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policija.Models
{
    class Auta
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Tablice { get; set; }
        public string Tip { get; set; }
        public int BrojMjesta { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public bool Slobodno { get; set; }
    }
}
