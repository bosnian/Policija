namespace Policija.Froms
{
    partial class FormOslobodi
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
            this.cbPritvorenik = new System.Windows.Forms.ComboBox();
            this.btnOslobodi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pritvorenik:";
            // 
            // cbPritvorenik
            // 
            this.cbPritvorenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPritvorenik.FormattingEnabled = true;
            this.cbPritvorenik.Location = new System.Drawing.Point(15, 77);
            this.cbPritvorenik.Name = "cbPritvorenik";
            this.cbPritvorenik.Size = new System.Drawing.Size(255, 24);
            this.cbPritvorenik.TabIndex = 1;
            // 
            // btnOslobodi
            // 
            this.btnOslobodi.Location = new System.Drawing.Point(164, 123);
            this.btnOslobodi.Name = "btnOslobodi";
            this.btnOslobodi.Size = new System.Drawing.Size(106, 48);
            this.btnOslobodi.TabIndex = 29;
            this.btnOslobodi.Text = "Oslobodi";
            this.btnOslobodi.UseVisualStyleBackColor = true;
            this.btnOslobodi.Click += new System.EventHandler(this.btnOslobodi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 123);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 48);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FormOslobodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 193);
            this.Controls.Add(this.btnOslobodi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbPritvorenik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormOslobodi";
            this.Text = "Oslobodi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPritvorenik;
        private System.Windows.Forms.Button btnOslobodi;
        private System.Windows.Forms.Button btnOdustani;
    }
}