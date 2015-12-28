namespace Hospital_Management_System
{
    partial class patient
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
            this.lblage = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblreasion = new System.Windows.Forms.Label();
            this.lbladmission = new System.Windows.Forms.Label();
            this.lblrelease = new System.Windows.Forms.Label();
            this.comboid = new System.Windows.Forms.ComboBox();
            this.combosex = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtreasion = new System.Windows.Forms.TextBox();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.txtrelease = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(23, 69);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 101);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(23, 136);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(25, 13);
            this.lblsex.TabIndex = 3;
            this.lblsex.Text = "Sex";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(23, 168);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "Age";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(23, 202);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Address";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(23, 242);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(61, 13);
            this.lblcontact.TabIndex = 6;
            this.lblcontact.Text = "Contact No";
            // 
            // lblreasion
            // 
            this.lblreasion.AutoSize = true;
            this.lblreasion.Location = new System.Drawing.Point(23, 270);
            this.lblreasion.Name = "lblreasion";
            this.lblreasion.Size = new System.Drawing.Size(107, 13);
            this.lblreasion.TabIndex = 7;
            this.lblreasion.Text = "Reasion of admission";
            // 
            // lbladmission
            // 
            this.lbladmission.AutoSize = true;
            this.lbladmission.Location = new System.Drawing.Point(23, 296);
            this.lbladmission.Name = "lbladmission";
            this.lbladmission.Size = new System.Drawing.Size(91, 13);
            this.lbladmission.TabIndex = 8;
            this.lbladmission.Text = "Date of admission";
            // 
            // lblrelease
            // 
            this.lblrelease.AutoSize = true;
            this.lblrelease.Location = new System.Drawing.Point(23, 330);
            this.lblrelease.Name = "lblrelease";
            this.lblrelease.Size = new System.Drawing.Size(72, 13);
            this.lblrelease.TabIndex = 9;
            this.lblrelease.Text = "Release Date";
            // 
            // comboid
            // 
            this.comboid.FormattingEnabled = true;
            this.comboid.Location = new System.Drawing.Point(166, 61);
            this.comboid.Name = "comboid";
            this.comboid.Size = new System.Drawing.Size(121, 21);
            this.comboid.TabIndex = 10;
            // 
            // combosex
            // 
            this.combosex.FormattingEnabled = true;
            this.combosex.Location = new System.Drawing.Point(166, 128);
            this.combosex.Name = "combosex";
            this.combosex.Size = new System.Drawing.Size(121, 21);
            this.combosex.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(166, 98);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 20);
            this.txtname.TabIndex = 12;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(166, 161);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 20);
            this.txtage.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(166, 199);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(241, 20);
            this.txtaddress.TabIndex = 14;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(166, 235);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(241, 20);
            this.txtcontact.TabIndex = 15;
            // 
            // txtreasion
            // 
            this.txtreasion.Location = new System.Drawing.Point(166, 263);
            this.txtreasion.Name = "txtreasion";
            this.txtreasion.Size = new System.Drawing.Size(241, 20);
            this.txtreasion.TabIndex = 16;
            // 
            // txtadmission
            // 
            this.txtadmission.Location = new System.Drawing.Point(166, 289);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(241, 20);
            this.txtadmission.TabIndex = 17;
            // 
            // txtrelease
            // 
            this.txtrelease.Location = new System.Drawing.Point(166, 323);
            this.txtrelease.Name = "txtrelease";
            this.txtrelease.Size = new System.Drawing.Size(241, 20);
            this.txtrelease.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Location = new System.Drawing.Point(27, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(305, 60);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(139, 60);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(139, 19);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(305, 19);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 655);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtrelease);
            this.Controls.Add(this.txtadmission);
            this.Controls.Add(this.txtreasion);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.combosex);
            this.Controls.Add(this.comboid);
            this.Controls.Add(this.lblrelease);
            this.Controls.Add(this.lbladmission);
            this.Controls.Add(this.lblreasion);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Name = "patient";
            this.Text = "patient";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblreasion;
        private System.Windows.Forms.Label lbladmission;
        private System.Windows.Forms.Label lblrelease;
        private System.Windows.Forms.ComboBox comboid;
        private System.Windows.Forms.ComboBox combosex;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtreasion;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.TextBox txtrelease;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}