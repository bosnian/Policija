namespace Policija.Froms
{
    partial class FormRazduzi
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
            this.cbRazduzivanje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRazduzivanje
            // 
            this.cbRazduzivanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRazduzivanje.FormattingEnabled = true;
            this.cbRazduzivanje.Location = new System.Drawing.Point(12, 60);
            this.cbRazduzivanje.Name = "cbRazduzivanje";
            this.cbRazduzivanje.Size = new System.Drawing.Size(258, 24);
            this.cbRazduzivanje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite za razduzivanje";
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.Location = new System.Drawing.Point(145, 109);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(127, 52);
            this.btnRazduzi.TabIndex = 15;
            this.btnRazduzi.Text = "Razduzi";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            this.btnRazduzi.Click += new System.EventHandler(this.btnRazduzi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 109);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(127, 52);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FromRazduzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 185);
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRazduzivanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FromRazduzi";
            this.Text = "Razduzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRazduzivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRazduzi;
        private System.Windows.Forms.Button btnOdustani;
    }
}