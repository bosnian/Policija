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
    public partial class FormDodajZapisnik : Form
    {
        public FormDodajZapisnik()
        {
            InitializeComponent();

            using (var db = new MojContext())
            {
                var lista = db.Zaposlenici.ToList();
                for (int i = 0; i < lista.Count(); i++)
                {
                    cbOsoba.Items.Add((lista[i].Id + " " + lista[i].Ime + " " + lista[i].Prezime).ToString());
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbNaziv.TextLength < 2 ||
                tbOpis.TextLength < 5 ||
                cbOsoba.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using (var db = new MojContext())
            {
                var temp = new Zapisnici();
                temp.Naziv = tbNaziv.Text.ToString();
                temp.Opis = tbOpis.Text.ToString();
                string[] t = cbOsoba.SelectedItem.ToString().Split(' ');
                temp.ZaposlenikId = Convert.ToInt32(t[0]);
                db.Zapisnici.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
