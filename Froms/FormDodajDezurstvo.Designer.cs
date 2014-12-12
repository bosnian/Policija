namespace Policija.Froms
{
    partial class FormDodajDezurstvo
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.cbDogadjaj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtUloga = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Dogadjaj:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(212, 168);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 48);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(16, 168);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Zaposlenik:";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(126, 40);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(192, 24);
            this.cbZaposlenik.TabIndex = 29;
            // 
            // cbDogadjaj
            // 
            this.cbDogadjaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDogadjaj.FormattingEnabled = true;
            this.cbDogadjaj.Location = new System.Drawing.Point(126, 73);
            this.cbDogadjaj.Name = "cbDogadjaj";
            this.cbDogadjaj.Size = new System.Drawing.Size(192, 24);
            this.cbDogadjaj.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Uloga:";
            // 
            // rtUloga
            // 
            this.rtUloga.Location = new System.Drawing.Point(126, 116);
            this.rtUloga.Name = "rtUloga";
            this.rtUloga.Size = new System.Drawing.Size(192, 46);
            this.rtUloga.TabIndex = 32;
            this.rtUloga.Text = "";
            // 
            // FormDodajDezurstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 228);
            this.Controls.Add(this.rtUloga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDogadjaj);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajDezurstvo";
            this.Text = "Dodaj dezurstvo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.ComboBox cbDogadjaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtUloga;
    }
}