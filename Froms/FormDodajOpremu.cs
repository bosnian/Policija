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
    public partial class FormDodajOpremu : Form
    {
        public FormDodajOpremu()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(tbNaziv.TextLength < 3 ||
                tbOpis.TextLength < 5)
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Oprema();
                temp.Naziv = tbNaziv.Text.ToString();
                temp.Opis = tbOpis.Text.ToString();
                temp.Slobodno = true;
                db.Oprema.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
