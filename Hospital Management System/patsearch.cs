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
    public partial class patsearch : Form
    {
        public patsearch()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            patient pt = new patient();
            this.Hide();
            pt.ShowDialog();

        }
    }
}
