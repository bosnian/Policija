﻿namespace Policija.Froms
{
    partial class FormReportZaposlenici
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.proceduraZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaReport = new Policija.BazaReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proceduraZaposleniciTableAdapter = new Policija.BazaReportTableAdapters.ProceduraZaposleniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proceduraZaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).BeginInit();
            this.SuspendLayout();
            // 
            // proceduraZaposleniciBindingSource
            // 
            this.proceduraZaposleniciBindingSource.DataMember = "ProceduraZaposlenici";
            this.proceduraZaposleniciBindingSource.DataSource = this.bazaReport;
            // 
            // bazaReport
            // 
            this.bazaReport.DataSetName = "BazaReport";
            this.bazaReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Zaposlenici";
            reportDataSource1.Value = this.proceduraZaposleniciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Policija.DAL.Reports.Zaposlenici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(903, 747);
            this.reportViewer1.TabIndex = 0;
            // 
            // proceduraZaposleniciTableAdapter
            // 
            this.proceduraZaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 747);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormReportZaposlenici";
            this.Text = "Izvjestaj o zaposlenicima";
            this.Load += new System.EventHandler(this.FormReportZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceduraZaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BazaReport bazaReport;
        private System.Windows.Forms.BindingSource proceduraZaposleniciBindingSource;
        private BazaReportTableAdapters.ProceduraZaposleniciTableAdapter proceduraZaposleniciTableAdapter;
    }
}