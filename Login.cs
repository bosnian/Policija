using Policija.DAL;
using Policija.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policija
{
    public partial class Login : Form
    {
        public bool logiran = false;
        public Login()
        {
            InitializeComponent();

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.ToString() == "admin" && tbPassword.Text.ToString() == "admin")
                logiran = true;
            this.Close();
        }

       
    }
}
