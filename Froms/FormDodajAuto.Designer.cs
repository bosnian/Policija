namespace Policija.Froms
{
    partial class FormDodajAuto
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
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tbTablice = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ndBroj = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ndBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tablice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj mjesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum proizvodnje:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(157, 142);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 22);
            this.dtDatum.TabIndex = 5;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(157, 38);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(200, 22);
            this.tbMarka.TabIndex = 6;
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(157, 64);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(200, 22);
            this.tbTip.TabIndex = 7;
            // 
            // tbTablice
            // 
            this.tbTablice.Location = new System.Drawing.Point(157, 90);
            this.tbTablice.Name = "tbTablice";
            this.tbTablice.Size = new System.Drawing.Size(200, 22);
            this.tbTablice.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(24, 183);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(127, 52);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(230, 183);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 52);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ndBroj
            // 
            this.ndBroj.Location = new System.Drawing.Point(157, 117);
            this.ndBroj.Name = "ndBroj";
            this.ndBroj.Size = new System.Drawing.Size(200, 22);
            this.ndBroj.TabIndex = 12;
            this.ndBroj.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormDodajAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 247);
            this.Controls.Add(this.ndBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbTablice);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajAuto";
            this.Text = "FormDodajAuto";
            ((System.ComponentModel.ISupportInitialize)(this.ndBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbTablice;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown ndBroj;
    }
}