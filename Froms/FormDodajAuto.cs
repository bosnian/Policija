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
    public partial class FormDodajAuto : Form
    {
        public FormDodajAuto()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(tbMarka.TextLength < 2 ||
                tbTip.TextLength < 2 ||
                tbTablice.TextLength < 2 ||
                ndBroj.Value <= 0)
            {
                MessageBox.Show("Provjerite podatke!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Auta();
                temp.BrojMjesta = Convert.ToInt32(ndBroj.Value);
                temp.Marka = tbMarka.Text.ToString();
                temp.Tip = tbTip.Text.ToString();
                temp.Tablice = tbTablice.Text.ToString();
                temp.DatumProizvodnje = dtDatum.Value;
                temp.Slobodno = true;
                db.Auta.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
