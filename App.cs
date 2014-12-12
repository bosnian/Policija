using Policija.DAL;
using Policija.Froms;
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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            UpdateTableZaposlenici();

            UpdateTableInventar();

            UpdateTableDezurstva();

            UpdateTablePritvor();
        }

        private void UpdateTablePritvor()
        {
            dgPritvor.Rows.Clear();
            using(var db = new MojContext())
            {
                var lista = db.Pritvor.Include("Osoba").ToList();
                for (int i = 0; i < lista.Count(); i++)
                {
                    string otpust;
                    if (lista[i].DatumOtpusta == new DateTime(1900, 1, 1))
                        otpust = " ";
                    else
                        otpust = lista[i].DatumOtpusta.ToString();

                    dgPritvor.Rows.Add(lista[i].Id,
                        lista[i].Osoba.Ime + " " + lista[i].Osoba.Prezime,
                        lista[i].ZapisnikId,
                        lista[i].DatumPritvora,
                        otpust);
                }
            }
        }

        private void UpdateTableDezurstva()
        {
            dgDezurstva.Rows.Clear();

            using(var db = new MojContext())
            {
                var lista = db.Dezurstvo.Include("Zaposlenik").Include("Dogadjaj").ToList();

                for (int i = 0; i < lista.Count(); i++)
                {
                    dgDezurstva.Rows.Add(lista[i].Id,
                        lista[i].Dogadjaj.Naziv,
                        lista[i].Dogadjaj.Opis,
                        lista[i].Zaposlenik.Ime + " " + lista[i].Zaposlenik.Prezime,
                        lista[i].Uloga);
                }
            }
            dgDezurstva.Refresh();
        }


        private void btnDodajZap_Click(object sender, EventArgs e)
        {
            var dodaj = new FormDodajZaposlenika();
            dodaj.ShowDialog();
            UpdateTableZaposlenici();
        }

        private void UpdateTableZaposlenici()
        {
            dgZaposlenici.Rows.Clear();
            using (var db = new MojContext())
            {
                var zaposlenici = db.Zaposlenici.Include("UlogaZaposlenika").ToList();

                for (int i = 0; i < zaposlenici.Count(); i++)
                {
                    dgZaposlenici.Rows.Add(zaposlenici[i].Id.ToString(),
                        zaposlenici[i].Ime,
                        zaposlenici[i].Prezime,
                        zaposlenici[i].UlogaZaposlenika.NazivUloge,
                        zaposlenici[i].JMBG,
                        zaposlenici[i].DatumRodjenja.ToString(),
                        zaposlenici[i].Adresa,
                        zaposlenici[i].DatumUnosa.ToString() );
                }
            }
            dgZaposlenici.Refresh();
        }

        private void UpdateTableInventar()
        {
            dgInventar.Rows.Clear();
            using(var db = new MojContext())
            {
                var lista = db.Zaduzivanje.Include("Auto").Include("Zaposlenik").Include("Oprema").ToList();
                for (int i = 0; i < lista.Count(); i++)
                {
                    string zaduzio = lista[i].Zaposlenik.Ime + " " + lista[i].Zaposlenik.Prezime;
                    string zaduzeno;
                    if(lista[i].OpremaId!=null)
                    {
                        zaduzeno = lista[i].Oprema.Naziv;
                    }
                    else
                    {
                        zaduzeno = lista[i].Auto.Marka + " " + lista[i].Auto.Tip + " " + lista[i].Auto.Tablice;
                    }
                    string datum;
                    if (lista[i].DatumRazduzivanja == new DateTime(1900, 1, 1))
                        datum = " ";
                    else
                        datum = lista[i].DatumRazduzivanja.ToString();
                    dgInventar.Rows.Add(lista[i].Id,
                        zaduzio,zaduzeno,
                        lista[i].DatumZaduzivanja.ToString(),
                        datum);
                        
                }
            }
            dgInventar.Refresh();
        }

        private void btnUrediZap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Potrebno implementirati!");
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            var form = new FormDodajUlogu();
            form.ShowDialog();
        }

        private void btnDodajAuto_Click(object sender, EventArgs e)
        {
            var form = new FormDodajAuto();
            form.ShowDialog();
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            var form = new FormDodajOpremu();
            form.ShowDialog();
        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            var form = new FormZaduzi();
            form.ShowDialog();
            UpdateTableInventar();
        }

        private void btnRazduzi_Click(object sender, EventArgs e)
        {
            var form = new FormRazduzi();
            form.ShowDialog();
            UpdateTableInventar();
        }

        private void btnVrstu_Click(object sender, EventArgs e)
        {
            var form = new FormVrstaDogadjaja();
            form.ShowDialog();
        }

        private void btnDogadjaj_Click(object sender, EventArgs e)
        {
            var form = new FormDodajDogadjaj();
            form.ShowDialog();
        }

        private void btnDezurstvo_Click(object sender, EventArgs e)
        {
            var form = new FormDodajDezurstvo();
            form.ShowDialog();
            UpdateTableDezurstva();
        }

        private void btnOsoba_Click(object sender, EventArgs e)
        {
            var form = new FormDodajOsobu();
            form.ShowDialog();
        }

        private void btnZapisnik_Click(object sender, EventArgs e)
        {
            var form = new FormDodajZapisnik();
            form.ShowDialog();
        }

        private void btnPritvor_Click(object sender, EventArgs e)
        {
            var form = new FormDodajPritvor();
            form.ShowDialog();
            UpdateTablePritvor();
        }

        private void btnOslobodi_Click(object sender, EventArgs e)
        {
            var form = new FormOslobodi();
            form.ShowDialog();
            UpdateTablePritvor();
        }

        private void btnIzvjestajZaposlenika_Click(object sender, EventArgs e)
        {
            var form = new FormReportZaposlenici();
            form.ShowDialog();
        }

        private void btnIzvjestajAuta_Click(object sender, EventArgs e)
        {
            var form = new FormReportAuta();
            form.ShowDialog();
        }

        private void btnIzvjestajOpreme_Click(object sender, EventArgs e)
        {
            var form = new FormReportOprema();
            form.ShowDialog();
        }

        private void btnIzvjestajDogadjaja_Click(object sender, EventArgs e)
        {
            var form = new FormReportDogadjaji();
            form.ShowDialog();
        }
    }
}
