namespace Policija
{
    partial class FormDodajZaposlenika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbMjesto = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.dtRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uloga:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "JMBG:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rodjenja:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grad:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mjesto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adresa:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(164, 43);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(176, 22);
            this.tbIme.TabIndex = 8;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(164, 75);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(176, 22);
            this.tbPrezime.TabIndex = 9;
            this.tbPrezime.TextChanged += new System.EventHandler(this.tbPrezime_TextChanged);
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(164, 146);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJMBG.Size = new System.Drawing.Size(176, 22);
            this.tbJMBG.TabIndex = 10;
            this.tbJMBG.TextChanged += new System.EventHandler(this.tbJMBG_TextChanged);
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(164, 213);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(176, 22);
            this.tbGrad.TabIndex = 11;
            this.tbGrad.TextChanged += new System.EventHandler(this.tbGrad_TextChanged);
            // 
            // tbMjesto
            // 
            this.tbMjesto.Location = new System.Drawing.Point(164, 241);
            this.tbMjesto.Name = "tbMjesto";
            this.tbMjesto.Size = new System.Drawing.Size(176, 22);
            this.tbMjesto.TabIndex = 12;
            this.tbMjesto.TextChanged += new System.EventHandler(this.tbMjesto_TextChanged);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(164, 272);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(176, 22);
            this.tbAdresa.TabIndex = 13;
            this.tbAdresa.TextChanged += new System.EventHandler(this.tbAdresa_TextChanged);
            // 
            // dtRodjenja
            // 
            this.dtRodjenja.Location = new System.Drawing.Point(164, 182);
            this.dtRodjenja.Name = "dtRodjenja";
            this.dtRodjenja.Size = new System.Drawing.Size(176, 22);
            this.dtRodjenja.TabIndex = 14;
            this.dtRodjenja.ValueChanged += new System.EventHandler(this.dtRodjenja_ValueChanged);
            // 
            // cbUloga
            // 
            this.cbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(164, 113);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(176, 24);
            this.cbUloga.TabIndex = 15;
            this.cbUloga.SelectedIndexChanged += new System.EventHandler(this.cbUloga_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(36, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 53);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 319);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 53);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Dodaj";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormDodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 395);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.dtRodjenja);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbMjesto);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajZaposlenika";
            this.Text = "Dodaj zaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbMjesto;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.DateTimePicker dtRodjenja;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
    }
}