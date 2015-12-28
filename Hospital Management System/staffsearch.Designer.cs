namespace Hospital_Management_System
{
    partial class staffsearch
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
            this.lblname = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(36, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(284, 135);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(161, 135);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(161, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(198, 20);
            this.txtname.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // staffsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblname);
            this.Name = "staffsearch";
            this.Text = "Staff Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}