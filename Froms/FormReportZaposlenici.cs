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
    public partial class FormReportZaposlenici : Form
    {
        public FormReportZaposlenici()
        {
            InitializeComponent();
        }

        private void FormReportZaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaReport.ProceduraZaposlenici' table. You can move, or remove it, as needed.
            this.proceduraZaposleniciTableAdapter.Fill(this.bazaReport.ProceduraZaposlenici);

            this.reportViewer1.RefreshReport();
        }
    }
}
