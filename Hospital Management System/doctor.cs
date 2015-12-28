using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using validation;


namespace Hospital_Management_System
{
    public partial class frmdoctor : Form
    {
        public frmdoctor()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            receptionist1 re = new receptionist1();
            this.Hide();
            re.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            doctorsearch ds = new doctorsearch();
            this.Hide();
            ds.ShowDialog();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            doctorMT objdoctor = new doctorMT();
            objdoctor.Did = comboid.Text;
            objdoctor.Dname = txtname.Text;
            objdoctor.Dsex = combosex.Text;
            //string Dsex = "";
            //if(
            //objdoctor.Daddress = txtaddress.Text;
            objdoctor.Demail = txtemail.Text;
            objdoctor.Dphone = txtcontact.Text;
            objdoctor.Ddpt = combodepartment.Text;
            objdoctor.Dqualification = txtqualification.Text;

            objdoctor.SaveD();
            MessageBox.Show(" Doctor Added. THANK YOU ");
            LoadDoctor();
        }

        private void frmdoctor_Load(object sender, EventArgs e)
        {
            LoadDoctor();
        }

        private void LoadDoctor()
        {
            doctorMT objdoctor = new doctorMT();

            dataGridViewdoctor.DataSource = objdoctor.LoadDoctor().Tables[0];

        }

       // private void dataGridViewdoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
    //    {
            //doctorMT obj = new doctorMT();
          //  dataGridViewdoctor.DataSource = obj.LoadDoctor().Tables[0];
        //}
        /*private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the customer Code
            //check if selected
            string strSelectCustomer = dataGridViewdoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
            // e.RowIndex gets the selected row
            //Cells[0] gets the customer code
            displayDoctor(strSelectCustomer);
        }*/

        /*private void displayDoctor(string DID)
        {
        }*/
    }
}
