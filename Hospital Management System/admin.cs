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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoctor fd = new frmdoctor();
            this.Hide();
            fd.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorsearch dc = new doctorsearch();
            
            this.Hide();
            dc.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient fd = new patient();
            this.Hide();
            fd.ShowDialog();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            patsearch fd = new patsearch();
            this.Hide();
            fd.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff fd = new staff();
            this.Hide();
            fd.ShowDialog();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            staffsearch fd = new staffsearch();
            this.Hide();
            fd.ShowDialog();
        }

        private void loqOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
