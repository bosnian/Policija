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
    public partial class FormDodajDezurstvo : Form
    {
        public FormDodajDezurstvo()
        {
            InitializeComponent();

            using(var db = new MojContext())
            {
                var listaU = db.Zaposlenici.ToList();

                for (int i = 0; i < listaU.Count(); i++)
                {
                    cbZaposlenik.Items.Add(listaU[i].Ime + " " + listaU[i].Prezime);
                }

                var listaD = db.Dogadjaji.ToList();
                for (int i = 0; i < listaD.Count(); i++)
                {
                    cbDogadjaj.Items.Add(listaD[i].Naziv);
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(cbDogadjaj.SelectedIndex == -1 ||
                cbZaposlenik.SelectedIndex == -1 ||
                rtUloga.TextLength < 5)
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Dezurstvo();
                var zstr = cbZaposlenik.SelectedItem.ToString().Split(' ');
                var z1 = zstr[0];
                var z2 = zstr[1];
                var z = db.Zaposlenici.Where(x => x.Ime == z1).ToList();
                var zt = z.Where(x => x.Prezime == z2).ToList()[0].Id;


                var d = db.Dogadjaji.Where(x => x.Naziv == cbDogadjaj.SelectedItem.ToString()).ToList()[0].Id;

                temp.Uloga = rtUloga.Text;
                temp.ZaposlenikId = zt;
                temp.DogadjajId = d;
                db.Dezurstvo.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
