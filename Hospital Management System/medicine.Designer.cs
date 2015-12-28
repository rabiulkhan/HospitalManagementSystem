namespace Hospital_Management_System
{
    partial class medicine
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
            this.lblexpire = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.comboid = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtexpire = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(22, 70);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(22, 106);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Medicine Name";
            // 
            // lblexpire
            // 
            this.lblexpire.AutoSize = true;
            this.lblexpire.Location = new System.Drawing.Point(22, 145);
            this.lblexpire.Name = "lblexpire";
            this.lblexpire.Size = new System.Drawing.Size(62, 13);
            this.lblexpire.TabIndex = 3;
            this.lblexpire.Text = "Expire Date";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(22, 185);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(46, 13);
            this.lblquantity.TabIndex = 4;
            this.lblquantity.Text = "Quantity";
            // 
            // comboid
            // 
            this.comboid.FormattingEnabled = true;
            this.comboid.Location = new System.Drawing.Point(132, 62);
            this.comboid.Name = "comboid";
            this.comboid.Size = new System.Drawing.Size(121, 21);
            this.comboid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(132, 103);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(250, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtexpire
            // 
            this.txtexpire.Location = new System.Drawing.Point(132, 142);
            this.txtexpire.Name = "txtexpire";
            this.txtexpire.Size = new System.Drawing.Size(250, 20);
            this.txtexpire.TabIndex = 7;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(132, 185);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(250, 20);
            this.txtquantity.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Location = new System.Drawing.Point(25, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(276, 19);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(107, 19);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(276, 71);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(107, 71);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtexpire);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.comboid);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblexpire);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Name = "medicine";
            this.Text = "medicine";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblexpire;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.ComboBox comboid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtexpire;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}