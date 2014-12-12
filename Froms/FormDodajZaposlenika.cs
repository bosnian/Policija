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

namespace Policija
{
    public partial class FormDodajZaposlenika : Form
    {
        public FormDodajZaposlenika()
        {
            InitializeComponent();
            using(var db = new MojContext())
            {
                var listaUloga = db.UlogeZaposlenika.ToList();
                for (int i = 0; i < listaUloga.Count(); i++)
                {
                    cbUloga.Items.Add(listaUloga[i].NazivUloge.ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //minimalna provjera
            //MessageBox.Show(cbUloga.SelectedIndex.ToString());

            if (tbIme.TextLength < 2 || 
                tbPrezime.TextLength < 2||
                tbMjesto.TextLength < 2 ||
                tbGrad.TextLength < 2 ||
                tbAdresa.TextLength < 2 ||
                tbJMBG.TextLength != 13 ||
                cbUloga.SelectedIndex.ToString() == "-1"
                )
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            var novi = new Zaposlenici();
            novi.Ime = tbIme.Text.ToString();
            novi.Prezime = tbPrezime.Text.ToString();
            novi.Mjesto = tbMjesto.Text.ToString();
            novi.Sifra = "-";
            novi.JMBG = tbJMBG.Text.ToString(); 
            novi.Grad = tbGrad.Text.ToString();
            novi.Adresa = tbAdresa.Text.ToString();
            novi.DatumRodjenja = dtRodjenja.Value;
            novi.DatumUnosa = DateTime.Now;
            novi.UlogaZaposlenikaId = cbUloga.SelectedIndex+1;
            using(var db = new MojContext())
            {
                db.Zaposlenici.Add(novi);
                db.SaveChanges();
            }
            this.Close();
        }

        private void cbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMjesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGrad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
