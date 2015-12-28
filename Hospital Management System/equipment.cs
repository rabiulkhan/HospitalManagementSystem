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
    public partial class equipment : Form
    {
        public equipment()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            equipmanlogin eq = new equipmanlogin();
            this.Hide();
            eq.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            equipsearch cc = new equipsearch();
            this.Hide();
            cc.ShowDialog();
        }
    }
}
