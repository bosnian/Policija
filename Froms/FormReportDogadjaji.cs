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
    public partial class FormReportDogadjaji : Form
    {
        public FormReportDogadjaji()
        {
            InitializeComponent();
        }

        private void FormReportDogadjaji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaReport.ProceduraDogadjaji' table. You can move, or remove it, as needed.
            this.proceduraDogadjajiTableAdapter.Fill(this.bazaReport.ProceduraDogadjaji);

            this.reportViewer1.RefreshReport();
        }
    }
}
