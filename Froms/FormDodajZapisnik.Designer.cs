namespace Policija.Froms
{
    partial class FormDodajZapisnik
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
            this.cbOsoba = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.tbOpis = new System.Windows.Forms.RichTextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOsoba
            // 
            this.cbOsoba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOsoba.FormattingEnabled = true;
            this.cbOsoba.Location = new System.Drawing.Point(110, 37);
            this.cbOsoba.Name = "cbOsoba";
            this.cbOsoba.Size = new System.Drawing.Size(200, 24);
            this.cbOsoba.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Zaposlenik:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(205, 225);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 48);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(8, 225);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(110, 71);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(200, 134);
            this.tbOpis.TabIndex = 25;
            this.tbOpis.Text = "";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(110, 6);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(200, 22);
            this.tbNaziv.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Naziv:";
            // 
            // FormDodajZapisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 279);
            this.Controls.Add(this.cbOsoba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajZapisnik";
            this.Text = "Dodaj zapisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOsoba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox tbOpis;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}