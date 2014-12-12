namespace Policija.Froms
{
    partial class FormDodajUlogu
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
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.RichTextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv uloge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(117, 46);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(153, 22);
            this.tbNaziv.TabIndex = 2;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(117, 75);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(153, 98);
            this.tbOpis.TabIndex = 3;
            this.tbOpis.Text = "";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(15, 193);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(164, 193);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 48);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormDodajUlogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajUlogu";
            this.Text = "Dodaj ulogu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.RichTextBox tbOpis;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
    }
}