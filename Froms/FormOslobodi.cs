using Policija.DAL;
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
    public partial class FormOslobodi : Form
    {
        public FormOslobodi()
        {
            InitializeComponent();

            using (var db = new MojContext())
            {
                var lista = db.Pritvor.Include("Osoba").Where(x => x.DatumOtpusta == new DateTime(1900, 1, 1)).ToList();
                for (int i = 0; i < lista.Count(); i++)
                {
                    cbPritvorenik.Items.Add(lista[i].Id + " " + lista[i].Osoba.Ime + " " + lista[i].Osoba.Prezime);
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOslobodi_Click(object sender, EventArgs e)
        {
            if(cbPritvorenik.SelectedIndex == -1 )
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                string[] t = cbPritvorenik.SelectedItem.ToString().Split(' ');
                int a = Convert.ToInt32(t[0]);

                db.Pritvor.Find(a).DatumOtpusta = DateTime.Now;
                db.SaveChanges();
            }
            this.Close();
        }



    }
}
