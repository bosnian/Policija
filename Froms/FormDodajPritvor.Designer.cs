namespace Policija.Froms
{
    partial class FormDodajPritvor
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cbOsobe = new System.Windows.Forms.ComboBox();
            this.cbZapisnici = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zapisnik:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(164, 129);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 48);
            this.btnDodaj.TabIndex = 29;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(15, 129);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cbOsobe
            // 
            this.cbOsobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOsobe.FormattingEnabled = true;
            this.cbOsobe.Location = new System.Drawing.Point(93, 35);
            this.cbOsobe.Name = "cbOsobe";
            this.cbOsobe.Size = new System.Drawing.Size(177, 24);
            this.cbOsobe.TabIndex = 30;
            // 
            // cbZapisnici
            // 
            this.cbZapisnici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZapisnici.FormattingEnabled = true;
            this.cbZapisnici.Location = new System.Drawing.Point(93, 66);
            this.cbZapisnici.Name = "cbZapisnici";
            this.cbZapisnici.Size = new System.Drawing.Size(177, 24);
            this.cbZapisnici.TabIndex = 31;
            // 
            // FormDodajPritvor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 192);
            this.Controls.Add(this.cbZapisnici);
            this.Controls.Add(this.cbOsobe);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDodajPritvor";
            this.Text = "Dodaj u pritvor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cbOsobe;
        private System.Windows.Forms.ComboBox cbZapisnici;
    }
}