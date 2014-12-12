using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policija.Froms
{
    public partial class FormReportAuta : Form
    {
        public FormReportAuta()
        {
            InitializeComponent();
        }

        private void FormIzvjestajAuta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaReport.ProceduraInventarAuta' table. You can move, or remove it, as needed.
            this.proceduraInventarAutaTableAdapter.Fill(this.bazaReport.ProceduraInventarAuta);

            this.reportViewer1.RefreshReport();
        }
    }
}
