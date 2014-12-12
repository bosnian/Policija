namespace Policija
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabZaposlenici = new System.Windows.Forms.TabPage();
            this.btnIzvjestajZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.dgZaposlenici = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatumRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatumUnosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajZap = new System.Windows.Forms.Button();
            this.tabInventar = new System.Windows.Forms.TabPage();
            this.btnIzvjestajOpreme = new System.Windows.Forms.Button();
            this.btnIzvjestajAuta = new System.Windows.Forms.Button();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.btnDodajAuto = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.dgInventar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDesavanja = new System.Windows.Forms.TabPage();
            this.dgDezurstva = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDezurstvo = new System.Windows.Forms.Button();
            this.btnDogadjaj = new System.Windows.Forms.Button();
            this.btnVrstu = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOslobodi = new System.Windows.Forms.Button();
            this.btnPritvor = new System.Windows.Forms.Button();
            this.btnZapisnik = new System.Windows.Forms.Button();
            this.btnOsoba = new System.Windows.Forms.Button();
            this.dgPritvor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzvjestajDogadjaja = new System.Windows.Forms.Button();
            this.tabCtrl.SuspendLayout();
            this.tabZaposlenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).BeginInit();
            this.tabInventar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventar)).BeginInit();
            this.tabDesavanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDezurstva)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPritvor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabZaposlenici);
            this.tabCtrl.Controls.Add(this.tabInventar);
            this.tabCtrl.Controls.Add(this.tabDesavanja);
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(990, 478);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabZaposlenici
            // 
            this.tabZaposlenici.Controls.Add(this.btnIzvjestajZaposlenika);
            this.tabZaposlenici.Controls.Add(this.btnDodajUlogu);
            this.tabZaposlenici.Controls.Add(this.dgZaposlenici);
            this.tabZaposlenici.Controls.Add(this.btnDodajZap);
            this.tabZaposlenici.Location = new System.Drawing.Point(4, 25);
            this.tabZaposlenici.Name = "tabZaposlenici";
            this.tabZaposlenici.Padding = new System.Windows.Forms.Padding(3);
            this.tabZaposlenici.Size = new System.Drawing.Size(982, 449);
            this.tabZaposlenici.TabIndex = 0;
            this.tabZaposlenici.Text = "Zaposlenici";
            this.tabZaposlenici.UseVisualStyleBackColor = true;
            // 
            // btnIzvjestajZaposlenika
            // 
            this.btnIzvjestajZaposlenika.Location = new System.Drawing.Point(395, 16);
            this.btnIzvjestajZaposlenika.Name = "btnIzvjestajZaposlenika";
            this.btnIzvjestajZaposlenika.Size = new System.Drawing.Size(152, 30);
            this.btnIzvjestajZaposlenika.TabIndex = 5;
            this.btnIzvjestajZaposlenika.Text = "Izvjestaj";
            this.btnIzvjestajZaposlenika.UseVisualStyleBackColor = true;
            this.btnIzvjestajZaposlenika.Click += new System.EventHandler(this.btnIzvjestajZaposlenika_Click);
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(199, 16);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(155, 31);
            this.btnDodajUlogu.TabIndex = 4;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // dgZaposlenici
            // 
            this.dgZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cIme,
            this.cPrezime,
            this.cUloga,
            this.cJMBG,
            this.cDatumRodj,
            this.cAdresa,
            this.cDatumUnosa});
            this.dgZaposlenici.Location = new System.Drawing.Point(6, 65);
            this.dgZaposlenici.MultiSelect = false;
            this.dgZaposlenici.Name = "dgZaposlenici";
            this.dgZaposlenici.RowTemplate.Height = 24;
            this.dgZaposlenici.Size = new System.Drawing.Size(970, 378);
            this.dgZaposlenici.TabIndex = 2;
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cIme
            // 
            this.cIme.HeaderText = "Ime";
            this.cIme.Name = "cIme";
            this.cIme.ReadOnly = true;
            // 
            // cPrezime
            // 
            this.cPrezime.HeaderText = "Prezime";
            this.cPrezime.Name = "cPrezime";
            this.cPrezime.ReadOnly = true;
            // 
            // cUloga
            // 
            this.cUloga.HeaderText = "Uloga";
            this.cUloga.Name = "cUloga";
            this.cUloga.ReadOnly = true;
            // 
            // cJMBG
            // 
            this.cJMBG.HeaderText = "JMBG";
            this.cJMBG.Name = "cJMBG";
            this.cJMBG.ReadOnly = true;
            // 
            // cDatumRodj
            // 
            this.cDatumRodj.HeaderText = "Datum rodjenja";
            this.cDatumRodj.Name = "cDatumRodj";
            this.cDatumRodj.ReadOnly = true;
            // 
            // cAdresa
            // 
            this.cAdresa.HeaderText = "Adresa";
            this.cAdresa.Name = "cAdresa";
            this.cAdresa.ReadOnly = true;
            // 
            // cDatumUnosa
            // 
            this.cDatumUnosa.HeaderText = "Datum unosa";
            this.cDatumUnosa.Name = "cDatumUnosa";
            this.cDatumUnosa.ReadOnly = true;
            // 
            // btnDodajZap
            // 
            this.btnDodajZap.Location = new System.Drawing.Point(6, 16);
            this.btnDodajZap.Name = "btnDodajZap";
            this.btnDodajZap.Size = new System.Drawing.Size(155, 31);
            this.btnDodajZap.TabIndex = 1;
            this.btnDodajZap.Text = "Dodaj zaposlenika";
            this.btnDodajZap.UseVisualStyleBackColor = true;
            this.btnDodajZap.Click += new System.EventHandler(this.btnDodajZap_Click);
            // 
            // tabInventar
            // 
            this.tabInventar.Controls.Add(this.btnIzvjestajOpreme);
            this.tabInventar.Controls.Add(this.btnIzvjestajAuta);
            this.tabInventar.Controls.Add(this.btnDodajOpremu);
            this.tabInventar.Controls.Add(this.btnDodajAuto);
            this.tabInventar.Controls.Add(this.btnRazduzi);
            this.tabInventar.Controls.Add(this.btnZaduzi);
            this.tabInventar.Controls.Add(this.dgInventar);
            this.tabInventar.Location = new System.Drawing.Point(4, 25);
            this.tabInventar.Name = "tabInventar";
            this.tabInventar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventar.Size = new System.Drawing.Size(982, 449);
            this.tabInventar.TabIndex = 1;
            this.tabInventar.Text = "Inventar";
            this.tabInventar.UseVisualStyleBackColor = true;
            // 
            // btnIzvjestajOpreme
            // 
            this.btnIzvjestajOpreme.Location = new System.Drawing.Point(811, 19);
            this.btnIzvjestajOpreme.Name = "btnIzvjestajOpreme";
            this.btnIzvjestajOpreme.Size = new System.Drawing.Size(155, 31);
            this.btnIzvjestajOpreme.TabIndex = 7;
            this.btnIzvjestajOpreme.Text = "Izvjestaj o opremi";
            this.btnIzvjestajOpreme.UseVisualStyleBackColor = true;
            this.btnIzvjestajOpreme.Click += new System.EventHandler(this.btnIzvjestajOpreme_Click);
            // 
            // btnIzvjestajAuta
            // 
            this.btnIzvjestajAuta.Location = new System.Drawing.Point(650, 19);
            this.btnIzvjestajAuta.Name = "btnIzvjestajAuta";
            this.btnIzvjestajAuta.Size = new System.Drawing.Size(155, 31);
            this.btnIzvjestajAuta.TabIndex = 6;
            this.btnIzvjestajAuta.Text = "Izvjestaj o autima";
            this.btnIzvjestajAuta.UseVisualStyleBackColor = true;
            this.btnIzvjestajAuta.Click += new System.EventHandler(this.btnIzvjestajAuta_Click);
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Location = new System.Drawing.Point(489, 19);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(155, 31);
            this.btnDodajOpremu.TabIndex = 5;
            this.btnDodajOpremu.Text = "Dodaj opremu";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // btnDodajAuto
            // 
            this.btnDodajAuto.Location = new System.Drawing.Point(328, 19);
            this.btnDodajAuto.Name = "btnDodajAuto";
            this.btnDodajAuto.Size = new System.Drawing.Size(155, 31);
            this.btnDodajAuto.TabIndex = 4;
            this.btnDodajAuto.Text = "Dodaj auto";
            this.btnDodajAuto.UseVisualStyleBackColor = true;
            this.btnDodajAuto.Click += new System.EventHandler(this.btnDodajAuto_Click);
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(167, 19);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(155, 31);
            this.btnRazduzi.TabIndex = 3;
            this.btnRazduzi.Text = "Razduzi";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            this.btnRazduzi.Click += new System.EventHandler(this.btnRazduzi_Click);
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.Location = new System.Drawing.Point(6, 19);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(155, 31);
            this.btnZaduzi.TabIndex = 2;
            this.btnZaduzi.Text = "Zaduzi";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // dgInventar
            // 
            this.dgInventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgInventar.Location = new System.Drawing.Point(6, 65);
            this.dgInventar.MultiSelect = false;
            this.dgInventar.Name = "dgInventar";
            this.dgInventar.ReadOnly = true;
            this.dgInventar.RowTemplate.Height = 24;
            this.dgInventar.Size = new System.Drawing.Size(970, 378);
            this.dgInventar.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Zaposlenik";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Zaduzeno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Datum zaduzivanja";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Datum razduzivanja";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tabDesavanja
            // 
            this.tabDesavanja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDesavanja.Controls.Add(this.btnIzvjestajDogadjaja);
            this.tabDesavanja.Controls.Add(this.dgDezurstva);
            this.tabDesavanja.Controls.Add(this.btnDezurstvo);
            this.tabDesavanja.Controls.Add(this.btnDogadjaj);
            this.tabDesavanja.Controls.Add(this.btnVrstu);
            this.tabDesavanja.Location = new System.Drawing.Point(4, 25);
            this.tabDesavanja.Name = "tabDesavanja";
            this.tabDesavanja.Size = new System.Drawing.Size(982, 449);
            this.tabDesavanja.TabIndex = 2;
            this.tabDesavanja.Text = "Dogadjaji";
            // 
            // dgDezurstva
            // 
            this.dgDezurstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDezurstva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgDezurstva.Location = new System.Drawing.Point(7, 65);
            this.dgDezurstva.MultiSelect = false;
            this.dgDezurstva.Name = "dgDezurstva";
            this.dgDezurstva.ReadOnly = true;
            this.dgDezurstva.RowTemplate.Height = 24;
            this.dgDezurstva.Size = new System.Drawing.Size(970, 378);
            this.dgDezurstva.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dogadjaj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis dogadjaja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Zaposlenik";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Uloga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnDezurstvo
            // 
            this.btnDezurstvo.Location = new System.Drawing.Point(432, 17);
            this.btnDezurstvo.Name = "btnDezurstvo";
            this.btnDezurstvo.Size = new System.Drawing.Size(156, 34);
            this.btnDezurstvo.TabIndex = 2;
            this.btnDezurstvo.Text = "Dodaj dezurstvo";
            this.btnDezurstvo.UseVisualStyleBackColor = true;
            this.btnDezurstvo.Click += new System.EventHandler(this.btnDezurstvo_Click);
            // 
            // btnDogadjaj
            // 
            this.btnDogadjaj.Location = new System.Drawing.Point(218, 17);
            this.btnDogadjaj.Name = "btnDogadjaj";
            this.btnDogadjaj.Size = new System.Drawing.Size(156, 34);
            this.btnDogadjaj.TabIndex = 1;
            this.btnDogadjaj.Text = "Dodaj dogadjaj";
            this.btnDogadjaj.UseVisualStyleBackColor = true;
            this.btnDogadjaj.Click += new System.EventHandler(this.btnDogadjaj_Click);
            // 
            // btnVrstu
            // 
            this.btnVrstu.Location = new System.Drawing.Point(25, 17);
            this.btnVrstu.Name = "btnVrstu";
            this.btnVrstu.Size = new System.Drawing.Size(167, 34);
            this.btnVrstu.TabIndex = 0;
            this.btnVrstu.Text = "Dodaj vrstu dogadjaja";
            this.btnVrstu.UseVisualStyleBackColor = true;
            this.btnVrstu.Click += new System.EventHandler(this.btnVrstu_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOslobodi);
            this.tabPage1.Controls.Add(this.btnPritvor);
            this.tabPage1.Controls.Add(this.btnZapisnik);
            this.tabPage1.Controls.Add(this.btnOsoba);
            this.tabPage1.Controls.Add(this.dgPritvor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(982, 449);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Zapisnici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOslobodi
            // 
            this.btnOslobodi.Location = new System.Drawing.Point(627, 15);
            this.btnOslobodi.Name = "btnOslobodi";
            this.btnOslobodi.Size = new System.Drawing.Size(167, 34);
            this.btnOslobodi.TabIndex = 8;
            this.btnOslobodi.Text = "Oslobodi";
            this.btnOslobodi.UseVisualStyleBackColor = true;
            this.btnOslobodi.Click += new System.EventHandler(this.btnOslobodi_Click);
            // 
            // btnPritvor
            // 
            this.btnPritvor.Location = new System.Drawing.Point(426, 15);
            this.btnPritvor.Name = "btnPritvor";
            this.btnPritvor.Size = new System.Drawing.Size(167, 34);
            this.btnPritvor.TabIndex = 7;
            this.btnPritvor.Text = "Dodaj u pritvor";
            this.btnPritvor.UseVisualStyleBackColor = true;
            this.btnPritvor.Click += new System.EventHandler(this.btnPritvor_Click);
            // 
            // btnZapisnik
            // 
            this.btnZapisnik.Location = new System.Drawing.Point(217, 15);
            this.btnZapisnik.Name = "btnZapisnik";
            this.btnZapisnik.Size = new System.Drawing.Size(167, 34);
            this.btnZapisnik.TabIndex = 6;
            this.btnZapisnik.Text = "Dodaj zapisnik";
            this.btnZapisnik.UseVisualStyleBackColor = true;
            this.btnZapisnik.Click += new System.EventHandler(this.btnZapisnik_Click);
            // 
            // btnOsoba
            // 
            this.btnOsoba.Location = new System.Drawing.Point(7, 15);
            this.btnOsoba.Name = "btnOsoba";
            this.btnOsoba.Size = new System.Drawing.Size(167, 34);
            this.btnOsoba.TabIndex = 5;
            this.btnOsoba.Text = "Dodaj osobu";
            this.btnOsoba.UseVisualStyleBackColor = true;
            this.btnOsoba.Click += new System.EventHandler(this.btnOsoba_Click);
            // 
            // dgPritvor
            // 
            this.dgPritvor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPritvor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgPritvor.Location = new System.Drawing.Point(7, 66);
            this.dgPritvor.MultiSelect = false;
            this.dgPritvor.Name = "dgPritvor";
            this.dgPritvor.ReadOnly = true;
            this.dgPritvor.RowTemplate.Height = 24;
            this.dgPritvor.Size = new System.Drawing.Size(970, 378);
            this.dgPritvor.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Osoba";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Broj zapisnika";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Datum pritvora";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Datum otpusta";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnIzvjestajDogadjaja
            // 
            this.btnIzvjestajDogadjaja.Location = new System.Drawing.Point(635, 17);
            this.btnIzvjestajDogadjaja.Name = "btnIzvjestajDogadjaja";
            this.btnIzvjestajDogadjaja.Size = new System.Drawing.Size(156, 34);
            this.btnIzvjestajDogadjaja.TabIndex = 4;
            this.btnIzvjestajDogadjaja.Text = "Izvjestaj";
            this.btnIzvjestajDogadjaja.UseVisualStyleBackColor = true;
            this.btnIzvjestajDogadjaja.Click += new System.EventHandler(this.btnIzvjestajDogadjaja_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 502);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Text = "App";
            this.tabCtrl.ResumeLayout(false);
            this.tabZaposlenici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).EndInit();
            this.tabInventar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventar)).EndInit();
            this.tabDesavanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDezurstva)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPritvor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabZaposlenici;
        private System.Windows.Forms.TabPage tabInventar;
        private System.Windows.Forms.Button btnDodajZap;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.TabPage tabDesavanja;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatumRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatumUnosa;
        private System.Windows.Forms.DataGridView dgInventar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnDodajAuto;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Button btnDezurstvo;
        private System.Windows.Forms.Button btnDogadjaj;
        private System.Windows.Forms.Button btnVrstu;
        private System.Windows.Forms.DataGridView dgDezurstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgPritvor;
        private System.Windows.Forms.Button btnOsoba;
        private System.Windows.Forms.Button btnZapisnik;
        private System.Windows.Forms.Button btnPritvor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnOslobodi;
        private System.Windows.Forms.Button btnIzvjestajZaposlenika;
        private System.Windows.Forms.Button btnIzvjestajOpreme;
        private System.Windows.Forms.Button btnIzvjestajAuta;
        private System.Windows.Forms.Button btnIzvjestajDogadjaja;
    }
}