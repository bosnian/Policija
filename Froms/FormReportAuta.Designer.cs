namespace Policija.Froms
{
    partial class FormReportAuta
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
            this.proceduraInventarAutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaReport = new Policija.BazaReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proceduraInventarAutaTableAdapter = new Policija.BazaReportTableAdapters.ProceduraInventarAutaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proceduraInventarAutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).BeginInit();
            this.SuspendLayout();
            // 
            // proceduraInventarAutaBindingSource
            // 
            this.proceduraInventarAutaBindingSource.DataMember = "ProceduraInventarAuta";
            this.proceduraInventarAutaBindingSource.DataSource = this.bazaReport;
            // 
            // bazaReport
            // 
            this.bazaReport.DataSetName = "BazaReport";
            this.bazaReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Auta";
            reportDataSource1.Value = this.proceduraInventarAutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Policija.DAL.Reports.Auta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(970, 696);
            this.reportViewer1.TabIndex = 0;
            // 
            // proceduraInventarAutaTableAdapter
            // 
            this.proceduraInventarAutaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 696);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReportAuta";
            this.Text = "Izvjestao o autima";
            this.Load += new System.EventHandler(this.FormIzvjestajAuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceduraInventarAutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BazaReport bazaReport;
        private System.Windows.Forms.BindingSource proceduraInventarAutaBindingSource;
        private BazaReportTableAdapters.ProceduraInventarAutaTableAdapter proceduraInventarAutaTableAdapter;
    }
}