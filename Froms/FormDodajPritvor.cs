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
    public partial class FormDodajPritvor : Form
    {
        public FormDodajPritvor()
        {
            InitializeComponent();

            using(var db = new MojContext())
            {
                var listaO = db.Osoba.ToList();

                for (int i = 0; i < listaO.Count(); i++)
                {
                    cbOsobe.Items.Add((listaO[i].Id + " " + listaO[i].Ime + " " + listaO[i].Prezime).ToString());
                }

                var listaZ = db.Zapisnici.ToList();

                for (int i = 0; i < listaZ.Count(); i++)
                {
                    cbZapisnici.Items.Add((listaZ[i].Id + " " + listaZ[i].Naziv).ToString());
                }
                
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if( cbOsobe.SelectedIndex == -1 ||
                cbZapisnici.SelectedIndex == -1)
            {
                MessageBox.Show("Provjerite polja!");
                return;
            }

            using(var db = new MojContext())
            {
                var temp = new Pritvor();
                temp.DatumPritvora = DateTime.Now;
                temp.DatumOtpusta = new DateTime(1900, 1, 1);
                string a =cbOsobe.SelectedItem.ToString().Split(' ')[0];
                int aO = Convert.ToInt32(a);
                var t = db.Pritvor.Where(x => x.OsobaId == aO).ToList();
                
                if(t.Count() > 0  && t[t.Count()-1].DatumOtpusta == new DateTime(1900,1,1))
                {
                    MessageBox.Show("Trenutno je u pritvoru!");
                    return;
                }

                temp.OsobaId = Convert.ToInt32(cbOsobe.SelectedItem.ToString().Split(' ')[0]);
                temp.ZapisnikId = Convert.ToInt32(cbZapisnici.SelectedItem.ToString().Split(' ')[0]);
                
                db.Pritvor.Add(temp);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
