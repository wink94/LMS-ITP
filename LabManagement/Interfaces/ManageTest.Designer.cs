namespace LabManagement.Interfaces
{
    partial class ManageTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestSearch = new System.Windows.Forms.TextBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.dgvTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateTest);
            this.panel1.Controls.Add(this.lblTestID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTestPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTestName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTestSearch);
            this.panel1.Controls.Add(this.dgvTests);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.Location = new System.Drawing.Point(117, 331);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTest.TabIndex = 4;
            this.btnUpdateTest.Text = "Update";
            this.btnUpdateTest.UseVisualStyleBackColor = true;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Location = new System.Drawing.Point(114, 66);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(35, 13);
            this.lblTestID.TabIndex = 3;
            this.lblTestID.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Test Price";
            // 
            // txtTestPrice
            // 
            this.txtTestPrice.Location = new System.Drawing.Point(117, 241);
            this.txtTestPrice.Name = "txtTestPrice";
            this.txtTestPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTestPrice.TabIndex = 1;
            this.txtTestPrice.TextChanged += new System.EventHandler(this.txtTestSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Name";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(117, 151);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(100, 20);
            this.txtTestName.TabIndex = 1;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Test";
            // 
            // txtTestSearch
            // 
            this.txtTestSearch.Location = new System.Drawing.Point(526, 59);
            this.txtTestSearch.Name = "txtTestSearch";
            this.txtTestSearch.Size = new System.Drawing.Size(100, 20);
            this.txtTestSearch.TabIndex = 1;
            this.txtTestSearch.TextChanged += new System.EventHandler(this.txtTestSearch_TextChanged);
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTestID,
            this.dgvTestName,
            this.dgvTestPrice,
            this.dgvDel});
            this.dgvTests.Location = new System.Drawing.Point(469, 171);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.Size = new System.Drawing.Size(413, 166);
            this.dgvTests.TabIndex = 0;
            this.dgvTests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellClick);
            // 
            // dgvTestID
            // 
            this.dgvTestID.DataPropertyName = "labTestID";
            this.dgvTestID.HeaderText = "TestID";
            this.dgvTestID.Name = "dgvTestID";
            this.dgvTestID.ReadOnly = true;
            this.dgvTestID.Width = 120;
            // 
            // dgvTestName
            // 
            this.dgvTestName.DataPropertyName = "labTestName";
            this.dgvTestName.HeaderText = "TestName";
            this.dgvTestName.Name = "dgvTestName";
            this.dgvTestName.ReadOnly = true;
            this.dgvTestName.Width = 120;
            // 
            // dgvTestPrice
            // 
            this.dgvTestPrice.DataPropertyName = "labTestPrice";
            this.dgvTestPrice.HeaderText = "TestPrice";
            this.dgvTestPrice.Name = "dgvTestPrice";
            this.dgvTestPrice.ReadOnly = true;
            this.dgvTestPrice.Width = 120;
            // 
            // dgvDel
            // 
            this.dgvDel.HeaderText = "Delete";
            this.dgvDel.Image = global::LabManagement.Properties.Resources.cancel_25px;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 50;
            // 
            // ManageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 661);
            this.Controls.Add(this.panel1);
            this.Name = "ManageTest";
            this.Text = "ManageTest";
            this.Load += new System.EventHandler(this.ManageTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestSearch;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
    }
}