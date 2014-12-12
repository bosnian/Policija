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
    public partial class FormVrstaDogadjaja : Form
    {
        public FormVrstaDogadjaja()
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
            }
            
            using(var db = new MojContext())
            {
                var temp = db.VrsteDogadjaja.FirstOrDefault(x => x.Naziv == tbNaziv.Text.ToString());

                if (temp != null && temp.Naziv == tbNaziv.Text.ToString())
                {
                    MessageBox.Show("Postoji vec uloga!");
                    return;
                }

                var t = new VrsteDogadjaja();
                t.Naziv = tbNaziv.Text.ToString();
                t.Opis = tbOpis.Text.ToString();
                db.VrsteDogadjaja.Add(t);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
