﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            receptionist1 re = new receptionist1();
            this.Hide();
            re.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            staffsearch st = new staffsearch();
            this.Hide();
            st.ShowDialog();
        }
    }
}
