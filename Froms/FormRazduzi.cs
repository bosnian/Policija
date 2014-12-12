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
    public partial class FormRazduzi : Form
    {
        public FormRazduzi()
        {
            InitializeComponent();

            using(var db = new MojContext())
            {
                var lista = db.Zaduzivanje.Include("Auto").Include("Zaposlenik")
                    .Include("Oprema").Where(x => x.DatumRazduzivanja == new DateTime(1900, 1, 1)).ToList();

                for (int i = 0; i < lista.Count(); i++)
                {
                    string zaduzeno;
                    if(lista[i].OpremaId!=null)
                    {
                        zaduzeno = lista[i].Oprema.Naziv;
                    }
                    else
                    {
                        zaduzeno = lista[i].Auto.Marka + " " + lista[i].Auto.Tip + " " + lista[i].Auto.Tablice;
                    }
                    cbRazduzivanje.Items.Add(lista[i].Id + " # " + zaduzeno + " - "
                        + lista[i].Zaposlenik.Ime + " " + lista[i].Zaposlenik.Prezime);
                }
                
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            if (cbRazduzivanje.SelectedIndex == -1 ||
                cbRazduzivanje.SelectedIndex == -1)
            {
                MessageBox.Show("Provjerite polje!");
                return;
            }

            using (var db = new MojContext())
            {
                
                string[] data = cbRazduzivanje.SelectedItem.ToString().Split(' ');
                int s = Convert.ToInt32(data[0]);
                db.Zaduzivanje.Where(x => x.Id == s).ToList()[0].DatumRazduzivanja = DateTime.Now;
                var temp = db.Zaduzivanje.Where(x => x.Id == s).ToList()[0];
                
               

                if(temp.AutoId!=null)
                {
                    db.Auta.Find(temp.AutoId).Slobodno = true;
                }
                else
                {
                    db.Oprema.Find(temp.OpremaId).Slobodno = true;
                }

                db.SaveChanges();


            }
            this.Close();
        }
    }
}
