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
    public partial class medicine : Form
    {
        public medicine()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            medmanlogin md = new medmanlogin();
            this.Hide();
            md.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            medsearch md = new medsearch();
            this.Hide();
            md.ShowDialog();
        }
    }
}
