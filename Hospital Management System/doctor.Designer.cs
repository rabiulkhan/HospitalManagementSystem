namespace Hospital_Management_System
{
    partial class frmdoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblqualification = new System.Windows.Forms.Label();
            this.comboid = new System.Windows.Forms.ComboBox();
            this.combosex = new System.Windows.Forms.ComboBox();
            this.combodepartment = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtqualification = new System.Windows.Forms.TextBox();
            this.groupBoxdoctor = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridViewdoctor = new System.Windows.Forms.DataGridView();
            this.groupBoxdoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Information";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(24, 69);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(24, 103);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(24, 140);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(25, 13);
            this.lblsex.TabIndex = 3;
            this.lblsex.Text = "Sex";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(24, 175);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(24, 211);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "E-mail";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(24, 242);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(61, 13);
            this.lblcontact.TabIndex = 6;
            this.lblcontact.Text = "Contact No";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(24, 278);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(62, 13);
            this.lbldepartment.TabIndex = 7;
            this.lbldepartment.Text = "Department";
            // 
            // lblqualification
            // 
            this.lblqualification.AutoSize = true;
            this.lblqualification.Location = new System.Drawing.Point(24, 313);
            this.lblqualification.Name = "lblqualification";
            this.lblqualification.Size = new System.Drawing.Size(65, 13);
            this.lblqualification.TabIndex = 8;
            this.lblqualification.Text = "Qualification";
            // 
            // comboid
            // 
            this.comboid.FormattingEnabled = true;
            this.comboid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboid.Location = new System.Drawing.Point(156, 66);
            this.comboid.Name = "comboid";
            this.comboid.Size = new System.Drawing.Size(121, 21);
            this.comboid.TabIndex = 9;
            // 
            // combosex
            // 
            this.combosex.FormattingEnabled = true;
            this.combosex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combosex.Location = new System.Drawing.Point(156, 137);
            this.combosex.Name = "combosex";
            this.combosex.Size = new System.Drawing.Size(121, 21);
            this.combosex.TabIndex = 10;
            // 
            // combodepartment
            // 
            this.combodepartment.FormattingEnabled = true;
            this.combodepartment.Items.AddRange(new object[] {
            "Medicine",
            "Gynologist",
            "Skin",
            "Dentist",
            "ENT"});
            this.combodepartment.Location = new System.Drawing.Point(156, 270);
            this.combodepartment.Name = "combodepartment";
            this.combodepartment.Size = new System.Drawing.Size(121, 21);
            this.combodepartment.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(156, 103);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(226, 20);
            this.txtname.TabIndex = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(156, 168);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(226, 20);
            this.txtaddress.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(156, 204);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(226, 20);
            this.txtemail.TabIndex = 14;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(156, 239);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(226, 20);
            this.txtcontact.TabIndex = 15;
            // 
            // txtqualification
            // 
            this.txtqualification.Location = new System.Drawing.Point(156, 313);
            this.txtqualification.Name = "txtqualification";
            this.txtqualification.Size = new System.Drawing.Size(226, 20);
            this.txtqualification.TabIndex = 16;
            // 
            // groupBoxdoctor
            // 
            this.groupBoxdoctor.Controls.Add(this.btnsearch);
            this.groupBoxdoctor.Controls.Add(this.btnback);
            this.groupBoxdoctor.Controls.Add(this.btninsert);
            this.groupBoxdoctor.Controls.Add(this.btnview);
            this.groupBoxdoctor.Location = new System.Drawing.Point(27, 390);
            this.groupBoxdoctor.Name = "groupBoxdoctor";
            this.groupBoxdoctor.Size = new System.Drawing.Size(424, 116);
            this.groupBoxdoctor.TabIndex = 17;
            this.groupBoxdoctor.TabStop = false;
            this.groupBoxdoctor.Text = "Option";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(280, 87);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(129, 87);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(280, 32);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(129, 32);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            // 
            // dataGridViewdoctor
            // 
            this.dataGridViewdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoctor.Location = new System.Drawing.Point(31, 549);
            this.dataGridViewdoctor.Name = "dataGridViewdoctor";
            this.dataGridViewdoctor.Size = new System.Drawing.Size(420, 150);
            this.dataGridViewdoctor.TabIndex = 18;
            // 
            // frmdoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 725);
            this.Controls.Add(this.dataGridViewdoctor);
            this.Controls.Add(this.groupBoxdoctor);
            this.Controls.Add(this.txtqualification);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.combodepartment);
            this.Controls.Add(this.combosex);
            this.Controls.Add(this.comboid);
            this.Controls.Add(this.lblqualification);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Name = "frmdoctor";
            this.Text = "Doctor Form";
            this.Load += new System.EventHandler(this.frmdoctor_Load);
            this.groupBoxdoctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblqualification;
        private System.Windows.Forms.ComboBox comboid;
        private System.Windows.Forms.ComboBox combosex;
        private System.Windows.Forms.ComboBox combodepartment;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtqualification;
        private System.Windows.Forms.GroupBox groupBoxdoctor;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridViewdoctor;
    }
}