using Policija.DAL;
using Policija.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policija.Froms
{
    public partial class FormZaduzi : Form
    {
        public int brojAuta;
        public FormZaduzi()
        {
            InitializeComponent();

            using(var db = new MojContext())
            {
                var listaAuta = db.Auta.Where(x => x.Slobodno == true).ToList();
                for (int i = 0; i < listaAuta.Count(); i++)
                {
                    cbObjekat.Items.Add(listaAuta[i].Id+" # "+listaAuta[i].Marka+" "
                    +listaAuta[i].Tip +" "+listaAuta[i].Tablice);
                }
                brojAuta = listaAuta.Count();
                var listaOpreme = db.Oprema.Where(x => x.Slobodno == true).ToList();
                for (int i = 0; i < listaOpreme.Count(); i++)
                {
                    cbObjekat.Items.Add(listaOpreme[i].Id+" # "+listaOpreme[i].Naziv+" - "+listaOpreme[i].Opis);
                }

                var listaUposlenika = db.Zaposlenici.ToList();
                for (int i = 0; i < listaUposlenika.Count(); i++)
                {
                    cbUposlenik.Items.Add(listaUposlenika[i].Id+" # "+listaUposlenika[i].Ime + " " + listaUposlenika[i].Prezime
                        + " - " + listaUposlenika[i].JMBG);
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            if(cbUposlenik.SelectedIndex == -1 ||
                cbObjekat.SelectedIndex == -1)
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Zaduzivanje();
                string[] data = cbUposlenik.SelectedItem.ToString().Split(' ');
                temp.ZaposlenikId = Convert.ToInt32(data[0]);
                
                if(cbObjekat.SelectedIndex >= brojAuta)
                {
                    string[] data2 = cbObjekat.SelectedItem.ToString().Split(' ');
                    temp.OpremaId = Convert.ToInt32(data2[0]);
                    db.Oprema.Find(temp.OpremaId).Slobodno = false;
                }
                else
                {
                    string[] data3 = cbObjekat.SelectedItem.ToString().Split(' ');
                    temp.AutoId = Convert.ToInt32(data3[0]);
                    db.Auta.Find(temp.AutoId).Slobodno = false;
                }

                temp.DatumZaduzivanja = DateTime.Now;
                temp.DatumRazduzivanja = new DateTime(1900, 1, 1);
                db.Zaduzivanje.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
