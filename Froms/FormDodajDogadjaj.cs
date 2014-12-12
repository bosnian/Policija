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
    public partial class FormDodajDogadjaj : Form
    {
        public FormDodajDogadjaj()
        {
            InitializeComponent();

            using (var db = new MojContext())
            {
                var lista = db.VrsteDogadjaja.ToList();
                for (int i = 0; i < lista.Count(); i++)
                {
                    cbVrsta.Items.Add((lista[i].Id + " " + lista[i].Naziv).ToString());
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if( tbNaziv.TextLength < 2 ||
                tbOpis.TextLength < 5 ||
                cbVrsta.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Dogadjaji();
                temp.Naziv = tbNaziv.Text.ToString();
                temp.Opis = tbOpis.Text.ToString();
                string[] t = cbVrsta.SelectedItem.ToString().Split(' ');
                temp.VrstaDogadjajaId = Convert.ToInt32(t[0]);
                temp.Datum = dtDatum.Value;
                db.Dogadjaji.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
