﻿namespace Policija.Froms
{
    partial class FormDodajDogadjaj
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.tbOpis = new System.Windows.Forms.RichTextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(212, 248);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 48);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(15, 248);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(117, 130);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(200, 98);
            this.tbOpis.TabIndex = 15;
            this.tbOpis.Text = "";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(117, 29);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(200, 22);
            this.tbNaziv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vrsta:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(117, 62);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 22);
            this.dtDatum.TabIndex = 20;
            // 
            // cbVrsta
            // 
            this.cbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(118, 92);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(200, 24);
            this.cbVrsta.TabIndex = 21;
            // 
            // FromDodajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 314);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FromDodajDogadjaj";
            this.Text = "Dodaj dogadjaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox tbOpis;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.ComboBox cbVrsta;
    }
}