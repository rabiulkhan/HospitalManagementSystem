using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class receplogin : Form
    {
        public receplogin()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            receptionist1 rc = new receptionist1();
            this.Hide();
            rc.ShowDialog();
        }
    }
}
