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
    public partial class FormDodajOsobu : Form
    {
        public FormDodajOsobu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbIme.TextLength < 2 ||
                tbPrezime.TextLength < 2 ||
                tbMjesto.TextLength < 2 ||
                tbGrad.TextLength < 2 ||
                tbAdresa.TextLength < 2 ||
                tbJMBG.TextLength != 13 ||
                tbDrzava.TextLength < 3
                )
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            var novi = new Osoba();
            novi.Ime = tbIme.Text.ToString();
            novi.Prezime = tbPrezime.Text.ToString();
            novi.Mjesto = tbMjesto.Text.ToString();
            novi.JMBG = tbJMBG.Text.ToString();
            novi.Grad = tbGrad.Text.ToString();
            novi.Adresa = tbAdresa.Text.ToString();
            novi.DatumRodjenja = dtRodjenja.Value;
            novi.DatumUnosa = DateTime.Now;
            novi.Drzava = tbDrzava.Text.ToString();
            using (var db = new MojContext())
            {
                db.Osoba.Add(novi);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
