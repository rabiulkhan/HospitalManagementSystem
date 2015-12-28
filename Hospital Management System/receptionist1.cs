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
    public partial class receptionist1 : Form
    {
        public receptionist1()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmdoctor fd = new frmdoctor();
            this.Hide();
            fd.ShowDialog();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorsearch ds = new doctorsearch();
            this.Hide();
            ds.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient pt = new patient();
            this.Hide();
            pt.ShowDialog();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            patsearch pt = new patsearch();
            this.Hide();
            pt.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff s = new staff();
            this.Hide();
            s.ShowDialog();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            staffsearch st = new staffsearch();
            this.Hide();
            st.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry,only Admin can remove");
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminlogin ad = new adminlogin();
            this.Hide();
            ad.ShowDialog();
        }
    }
}
