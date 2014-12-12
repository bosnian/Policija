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
    public partial class FormDodajUlogu : Form
    {
        public FormDodajUlogu()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if( tbNaziv.TextLength < 3 ||
                tbOpis.TextLength < 5)
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = db.UlogeZaposlenika.FirstOrDefault(x => x.NazivUloge == tbNaziv.Text.ToString());
                
                if(temp != null && temp.NazivUloge == tbNaziv.Text.ToString())
                {
                    MessageBox.Show("Postoji vec uloga!");
                    return;
                }

                var t = new UlogeZaposlenika();
                t.NazivUloge = tbNaziv.Text.ToString();
                t.OpisUloge = tbOpis.Text.ToString();
                db.UlogeZaposlenika.Add(t);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
