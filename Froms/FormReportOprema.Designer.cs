namespace Policija.Froms
{
    partial class FormReportOprema
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bazaReport = new Policija.BazaReport();
            this.proceduraInventarOpremeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceduraInventarOpremeTableAdapter = new Policija.BazaReportTableAdapters.ProceduraInventarOpremeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduraInventarOpremeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Oprema";
            reportDataSource1.Value = this.proceduraInventarOpremeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Policija.DAL.Reports.Oprema.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(940, 663);
            this.reportViewer1.TabIndex = 0;
            // 
            // bazaReport
            // 
            this.bazaReport.DataSetName = "BazaReport";
            this.bazaReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proceduraInventarOpremeBindingSource
            // 
            this.proceduraInventarOpremeBindingSource.DataMember = "ProceduraInventarOpreme";
            this.proceduraInventarOpremeBindingSource.DataSource = this.bazaReport;
            // 
            // proceduraInventarOpremeTableAdapter
            // 
            this.proceduraInventarOpremeTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 663);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReportOprema";
            this.Text = "Izvjesta o opremi";
            this.Load += new System.EventHandler(this.FormReportOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduraInventarOpremeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BazaReport bazaReport;
        private System.Windows.Forms.BindingSource proceduraInventarOpremeBindingSource;
        private BazaReportTableAdapters.ProceduraInventarOpremeTableAdapter proceduraInventarOpremeTableAdapter;
    }
}