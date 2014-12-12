namespace Policija.Froms
{
    partial class FormDodajOsobu
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtRodjenja = new System.Windows.Forms.DateTimePicker();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbMjesto = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 299);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 53);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Dodaj";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 53);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtRodjenja
            // 
            this.dtRodjenja.Location = new System.Drawing.Point(143, 128);
            this.dtRodjenja.Name = "dtRodjenja";
            this.dtRodjenja.Size = new System.Drawing.Size(176, 22);
            this.dtRodjenja.TabIndex = 32;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(143, 252);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(176, 22);
            this.tbAdresa.TabIndex = 31;
            // 
            // tbMjesto
            // 
            this.tbMjesto.Location = new System.Drawing.Point(143, 221);
            this.tbMjesto.Name = "tbMjesto";
            this.tbMjesto.Size = new System.Drawing.Size(176, 22);
            this.tbMjesto.TabIndex = 30;
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(143, 193);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(176, 22);
            this.tbGrad.TabIndex = 29;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(143, 92);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJMBG.Size = new System.Drawing.Size(176, 22);
            this.tbJMBG.TabIndex = 28;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(143, 55);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(176, 22);
            this.tbPrezime.TabIndex = 27;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(143, 23);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(176, 22);
            this.tbIme.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mjesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Grad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Drzava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(143, 165);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.Size = new System.Drawing.Size(172, 22);
            this.tbDrzava.TabIndex = 36;
            // 
            // FromDodajOsobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 363);
            this.Controls.Add(this.tbDrzava);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
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
            this.Name = "FromDodajOsobu";
            this.Text = "Dodaj osobu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtRodjenja;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbMjesto;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDrzava;
    }
}