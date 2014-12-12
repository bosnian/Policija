namespace Policija.Froms
{
    partial class FormZaduzi
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
            this.cbUposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbObjekat = new System.Windows.Forms.ComboBox();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uposlenik:";
            // 
            // cbUposlenik
            // 
            this.cbUposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUposlenik.FormattingEnabled = true;
            this.cbUposlenik.Location = new System.Drawing.Point(121, 39);
            this.cbUposlenik.Name = "cbUposlenik";
            this.cbUposlenik.Size = new System.Drawing.Size(233, 24);
            this.cbUposlenik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Auto/Oprema:";
            // 
            // cbObjekat
            // 
            this.cbObjekat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjekat.FormattingEnabled = true;
            this.cbObjekat.Location = new System.Drawing.Point(121, 76);
            this.cbObjekat.Name = "cbObjekat";
            this.cbObjekat.Size = new System.Drawing.Size(233, 24);
            this.cbObjekat.TabIndex = 3;
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.Location = new System.Drawing.Point(221, 114);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(127, 52);
            this.btnZaduzi.TabIndex = 13;
            this.btnZaduzi.Text = "Zaduzi";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(15, 114);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(127, 52);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FormZaduzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 178);
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbObjekat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUposlenik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormZaduzi";
            this.Text = "Zaduzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbObjekat;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Button btnOdustani;
    }
}