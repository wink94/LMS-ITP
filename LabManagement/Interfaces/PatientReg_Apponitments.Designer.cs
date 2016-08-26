namespace LabManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabCtrlPReg_App = new System.Windows.Forms.TabControl();
            this.tabPRegister = new System.Windows.Forms.TabPage();
            this.btnSetAppLimit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetAppointmenToday = new System.Windows.Forms.Button();
            this.btnSetAppmnt = new System.Windows.Forms.Button();
            this.gBxSelectApmnt = new System.Windows.Forms.GroupBox();
            this.dateAppDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pboxAdd = new System.Windows.Forms.PictureBox();
            this.pboxRemove = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lstPTests = new System.Windows.Forms.ListBox();
            this.lstTests = new System.Windows.Forms.ListBox();
            this.txtPSearchTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchAppmntByDate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLPPhoneUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLPAgeUpdate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLPNameUpdate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbLPGenderUpdate = new System.Windows.Forms.ComboBox();
            this.txtLPEmailUpdate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateLPAppDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLPUpdate = new System.Windows.Forms.Button();
            this.btnLPUpdateCancel = new System.Windows.Forms.Button();
            this.dgvAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbvAppointmentDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabCtrlPReg_App.SuspendLayout();
            this.tabPRegister.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBxSelectApmnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRemove)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlPReg_App
            // 
            this.tabCtrlPReg_App.Controls.Add(this.tabPRegister);
            this.tabCtrlPReg_App.Controls.Add(this.tabPage2);
            this.tabCtrlPReg_App.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlPReg_App.Location = new System.Drawing.Point(12, 2);
            this.tabCtrlPReg_App.Name = "tabCtrlPReg_App";
            this.tabCtrlPReg_App.SelectedIndex = 0;
            this.tabCtrlPReg_App.Size = new System.Drawing.Size(1170, 700);
            this.tabCtrlPReg_App.TabIndex = 0;
            this.tabCtrlPReg_App.SelectedIndexChanged += new System.EventHandler(this.tabCtrlPReg_App_SelectedIndexChanged);
            // 
            // tabPRegister
            // 
            this.tabPRegister.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tabPRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPRegister.Controls.Add(this.btnSetAppLimit);
            this.tabPRegister.Controls.Add(this.groupBox3);
            this.tabPRegister.Controls.Add(this.groupBox1);
            this.tabPRegister.Controls.Add(this.button2);
            this.tabPRegister.Controls.Add(this.pictureBox3);
            this.tabPRegister.Controls.Add(this.pboxAdd);
            this.tabPRegister.Controls.Add(this.pboxRemove);
            this.tabPRegister.Controls.Add(this.btnPreview);
            this.tabPRegister.Controls.Add(this.lstPTests);
            this.tabPRegister.Controls.Add(this.lstTests);
            this.tabPRegister.Controls.Add(this.txtPSearchTest);
            this.tabPRegister.Controls.Add(this.label6);
            this.tabPRegister.Controls.Add(this.cmbGender);
            this.tabPRegister.Controls.Add(this.txtPPhone);
            this.tabPRegister.Controls.Add(this.label3);
            this.tabPRegister.Controls.Add(this.txtPAge);
            this.tabPRegister.Controls.Add(this.label2);
            this.tabPRegister.Controls.Add(this.txtPEmail);
            this.tabPRegister.Controls.Add(this.label5);
            this.tabPRegister.Controls.Add(this.label4);
            this.tabPRegister.Controls.Add(this.txtPName);
            this.tabPRegister.Controls.Add(this.label1);
            this.tabPRegister.Location = new System.Drawing.Point(4, 29);
            this.tabPRegister.Name = "tabPRegister";
            this.tabPRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRegister.Size = new System.Drawing.Size(1162, 667);
            this.tabPRegister.TabIndex = 0;
            this.tabPRegister.Text = "Patient Registraion";
            // 
            // btnSetAppLimit
            // 
            this.btnSetAppLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAppLimit.Location = new System.Drawing.Point(867, 438);
            this.btnSetAppLimit.Name = "btnSetAppLimit";
            this.btnSetAppLimit.Size = new System.Drawing.Size(109, 36);
            this.btnSetAppLimit.TabIndex = 21;
            this.btnSetAppLimit.Text = "SetAppLimit";
            this.btnSetAppLimit.UseVisualStyleBackColor = true;
            this.btnSetAppLimit.Click += new System.EventHandler(this.btnSetAppLimit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(867, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 137);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Set Daily Apponitment Limit";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnSetAppointmenToday);
            this.groupBox1.Controls.Add(this.btnSetAppmnt);
            this.groupBox1.Controls.Add(this.gBxSelectApmnt);
            this.groupBox1.Controls.Add(this.lblAppNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(784, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 251);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // btnSetAppointmenToday
            // 
            this.btnSetAppointmenToday.Location = new System.Drawing.Point(263, 98);
            this.btnSetAppointmenToday.Name = "btnSetAppointmenToday";
            this.btnSetAppointmenToday.Size = new System.Drawing.Size(82, 56);
            this.btnSetAppointmenToday.TabIndex = 19;
            this.btnSetAppointmenToday.Text = "Today";
            this.btnSetAppointmenToday.UseVisualStyleBackColor = true;
            this.btnSetAppointmenToday.Click += new System.EventHandler(this.btnSetAppmntToday_Click);
            // 
            // btnSetAppmnt
            // 
            this.btnSetAppmnt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAppmnt.Location = new System.Drawing.Point(6, 98);
            this.btnSetAppmnt.Name = "btnSetAppmnt";
            this.btnSetAppmnt.Size = new System.Drawing.Size(104, 36);
            this.btnSetAppmnt.TabIndex = 19;
            this.btnSetAppmnt.Text = "Select Date";
            this.btnSetAppmnt.UseVisualStyleBackColor = true;
            this.btnSetAppmnt.Click += new System.EventHandler(this.btnSetAppmnt_Click);
            // 
            // gBxSelectApmnt
            // 
            this.gBxSelectApmnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gBxSelectApmnt.Controls.Add(this.dateAppDate);
            this.gBxSelectApmnt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxSelectApmnt.Location = new System.Drawing.Point(6, 140);
            this.gBxSelectApmnt.Name = "gBxSelectApmnt";
            this.gBxSelectApmnt.Size = new System.Drawing.Size(227, 78);
            this.gBxSelectApmnt.TabIndex = 14;
            this.gBxSelectApmnt.TabStop = false;
            this.gBxSelectApmnt.Text = "Schedule Apponitment";
            // 
            // dateAppDate
            // 
            this.dateAppDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAppDate.Location = new System.Drawing.Point(6, 39);
            this.dateAppDate.Name = "dateAppDate";
            this.dateAppDate.Size = new System.Drawing.Size(200, 22);
            this.dateAppDate.TabIndex = 16;
            this.dateAppDate.ValueChanged += new System.EventHandler(this.dateAppDate_ValueChanged);
            // 
            // lblAppNum
            // 
            this.lblAppNum.AutoSize = true;
            this.lblAppNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAppNum.Location = new System.Drawing.Point(231, 50);
            this.lblAppNum.Name = "lblAppNum";
            this.lblAppNum.Size = new System.Drawing.Size(34, 25);
            this.lblAppNum.TabIndex = 18;
            this.lblAppNum.Text = "18";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Appointments Number";
            // 
            // button2
            // 
            this.button2.Image = global::LabManagement.Properties.Resources.back2;
            this.button2.Location = new System.Drawing.Point(1076, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 50);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::LabManagement.Properties.Resources.search_icon_png_251;
            this.pictureBox3.Location = new System.Drawing.Point(389, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pboxAdd
            // 
            this.pboxAdd.Image = global::LabManagement.Properties.Resources.blue_right_arrow_icon_201;
            this.pboxAdd.Location = new System.Drawing.Point(411, 407);
            this.pboxAdd.Name = "pboxAdd";
            this.pboxAdd.Size = new System.Drawing.Size(50, 50);
            this.pboxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxAdd.TabIndex = 8;
            this.pboxAdd.TabStop = false;
            this.pboxAdd.Click += new System.EventHandler(this.pboxAdd_Click);
            this.pboxAdd.MouseLeave += new System.EventHandler(this.pboxAdd_MouseLeave);
            this.pboxAdd.MouseHover += new System.EventHandler(this.pboxAdd_MouseHover);
            // 
            // pboxRemove
            // 
            this.pboxRemove.Image = global::LabManagement.Properties.Resources.blue_left_arrow_icon_20;
            this.pboxRemove.Location = new System.Drawing.Point(411, 481);
            this.pboxRemove.Name = "pboxRemove";
            this.pboxRemove.Size = new System.Drawing.Size(50, 50);
            this.pboxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxRemove.TabIndex = 8;
            this.pboxRemove.TabStop = false;
            this.pboxRemove.Click += new System.EventHandler(this.pboxRemove_Click);
            this.pboxRemove.MouseLeave += new System.EventHandler(this.pboxRemove_MouseLeave);
            this.pboxRemove.MouseHover += new System.EventHandler(this.pboxRemove_MouseHover);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPreview.Location = new System.Drawing.Point(623, 555);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(80, 30);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lstPTests
            // 
            this.lstPTests.FormattingEnabled = true;
            this.lstPTests.ItemHeight = 20;
            this.lstPTests.Location = new System.Drawing.Point(518, 407);
            this.lstPTests.Name = "lstPTests";
            this.lstPTests.Size = new System.Drawing.Size(180, 124);
            this.lstPTests.TabIndex = 5;
            // 
            // lstTests
            // 
            this.lstTests.FormattingEnabled = true;
            this.lstTests.ItemHeight = 20;
            this.lstTests.Location = new System.Drawing.Point(186, 407);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(180, 124);
            this.lstTests.TabIndex = 5;
            // 
            // txtPSearchTest
            // 
            this.txtPSearchTest.Location = new System.Drawing.Point(189, 346);
            this.txtPSearchTest.Name = "txtPSearchTest";
            this.txtPSearchTest.Size = new System.Drawing.Size(180, 27);
            this.txtPSearchTest.TabIndex = 4;
            this.txtPSearchTest.TextChanged += new System.EventHandler(this.txtPSearchTest_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search Test";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(518, 169);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(107, 28);
            this.cmbGender.TabIndex = 2;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Location = new System.Drawing.Point(189, 253);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Size = new System.Drawing.Size(180, 27);
            this.txtPPhone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // txtPAge
            // 
            this.txtPAge.Location = new System.Drawing.Point(189, 178);
            this.txtPAge.Name = "txtPAge";
            this.txtPAge.Size = new System.Drawing.Size(180, 27);
            this.txtPAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(518, 98);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(180, 27);
            this.txtPEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(189, 98);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(180, 27);
            this.txtPName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Appointments";
            // 
            // button1
            // 
            this.button1.Image = global::LabManagement.Properties.Resources.back2;
            this.button1.Location = new System.Drawing.Point(1097, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 50);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnSearchAppmntByDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvAppointmentList);
            this.groupBox2.Controls.Add(this.dateTo);
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.Controls.Add(this.txtAppointmentSearch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 531);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSearchAppmntByDate
            // 
            this.btnSearchAppmntByDate.Image = global::LabManagement.Properties.Resources.search_35px;
            this.btnSearchAppmntByDate.Location = new System.Drawing.Point(598, 118);
            this.btnSearchAppmntByDate.Name = "btnSearchAppmntByDate";
            this.btnSearchAppmntByDate.Size = new System.Drawing.Size(36, 36);
            this.btnSearchAppmntByDate.TabIndex = 16;
            this.btnSearchAppmntByDate.UseVisualStyleBackColor = true;
            this.btnSearchAppmntByDate.Click += new System.EventHandler(this.btnSearchAppmntByDate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(7, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(327, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "To";
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Location = new System.Drawing.Point(367, 132);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 13;
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Location = new System.Drawing.Point(66, 132);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 22);
            this.dateFrom.TabIndex = 12;
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(227, 48);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(100, 25);
            this.txtAppointmentSearch.TabIndex = 10;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Search Appointments";
            // 
            // dgvAppointmentList
            // 
            this.dgvAppointmentList.AllowUserToDeleteRows = false;
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAppointmentID,
            this.dgvPatientID,
            this.dgvPatientName,
            this.dgvAppointmentDate,
            this.dbvAppointmentDelete});
            this.dgvAppointmentList.Location = new System.Drawing.Point(25, 243);
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.ReadOnly = true;
            this.dgvAppointmentList.RowHeadersVisible = false;
            this.dgvAppointmentList.Size = new System.Drawing.Size(500, 208);
            this.dgvAppointmentList.TabIndex = 8;
            this.dgvAppointmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentList_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::LabManagement.Properties.Resources.cancel_25px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btnLPUpdateCancel);
            this.groupBox4.Controls.Add(this.btnLPUpdate);
            this.groupBox4.Controls.Add(this.dateLPAppDateUpdate);
            this.groupBox4.Controls.Add(this.cmbLPGenderUpdate);
            this.groupBox4.Controls.Add(this.txtLPEmailUpdate);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtLPPhoneUpdate);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtLPAgeUpdate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtLPNameUpdate);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(33, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 508);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txtLPPhoneUpdate
            // 
            this.txtLPPhoneUpdate.Location = new System.Drawing.Point(153, 166);
            this.txtLPPhoneUpdate.Name = "txtLPPhoneUpdate";
            this.txtLPPhoneUpdate.Size = new System.Drawing.Size(180, 27);
            this.txtLPPhoneUpdate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone";
            // 
            // txtLPAgeUpdate
            // 
            this.txtLPAgeUpdate.Location = new System.Drawing.Point(153, 114);
            this.txtLPAgeUpdate.Name = "txtLPAgeUpdate";
            this.txtLPAgeUpdate.Size = new System.Drawing.Size(180, 27);
            this.txtLPAgeUpdate.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Age";
            // 
            // txtLPNameUpdate
            // 
            this.txtLPNameUpdate.Location = new System.Drawing.Point(153, 59);
            this.txtLPNameUpdate.Name = "txtLPNameUpdate";
            this.txtLPNameUpdate.Size = new System.Drawing.Size(180, 27);
            this.txtLPNameUpdate.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Name";
            // 
            // cmbLPGenderUpdate
            // 
            this.cmbLPGenderUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLPGenderUpdate.FormattingEnabled = true;
            this.cmbLPGenderUpdate.Location = new System.Drawing.Point(153, 276);
            this.cmbLPGenderUpdate.Name = "cmbLPGenderUpdate";
            this.cmbLPGenderUpdate.Size = new System.Drawing.Size(107, 28);
            this.cmbLPGenderUpdate.TabIndex = 11;
            // 
            // txtLPEmailUpdate
            // 
            this.txtLPEmailUpdate.Location = new System.Drawing.Point(153, 220);
            this.txtLPEmailUpdate.Name = "txtLPEmailUpdate";
            this.txtLPEmailUpdate.Size = new System.Drawing.Size(180, 27);
            this.txtLPEmailUpdate.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gender";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Email";
            // 
            // dateLPAppDateUpdate
            // 
            this.dateLPAppDateUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLPAppDateUpdate.Location = new System.Drawing.Point(153, 338);
            this.dateLPAppDateUpdate.Name = "dateLPAppDateUpdate";
            this.dateLPAppDateUpdate.Size = new System.Drawing.Size(205, 23);
            this.dateLPAppDateUpdate.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 343);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "Date";
            // 
            // btnLPUpdate
            // 
            this.btnLPUpdate.Location = new System.Drawing.Point(185, 449);
            this.btnLPUpdate.Name = "btnLPUpdate";
            this.btnLPUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnLPUpdate.TabIndex = 13;
            this.btnLPUpdate.Text = "Update";
            this.btnLPUpdate.UseVisualStyleBackColor = true;
            this.btnLPUpdate.Click += new System.EventHandler(this.btnLPUpdate_Click);
            // 
            // btnLPUpdateCancel
            // 
            this.btnLPUpdateCancel.Location = new System.Drawing.Point(283, 449);
            this.btnLPUpdateCancel.Name = "btnLPUpdateCancel";
            this.btnLPUpdateCancel.Size = new System.Drawing.Size(75, 31);
            this.btnLPUpdateCancel.TabIndex = 13;
            this.btnLPUpdateCancel.Text = "Cancel";
            this.btnLPUpdateCancel.UseVisualStyleBackColor = true;
            this.btnLPUpdateCancel.Click += new System.EventHandler(this.btnLPUpdateCancel_Click);
            // 
            // dgvAppointmentID
            // 
            this.dgvAppointmentID.DataPropertyName = "labAppointmentID";
            this.dgvAppointmentID.HeaderText = "Appointment ID";
            this.dgvAppointmentID.Name = "dgvAppointmentID";
            this.dgvAppointmentID.ReadOnly = true;
            this.dgvAppointmentID.Width = 115;
            // 
            // dgvPatientID
            // 
            this.dgvPatientID.DataPropertyName = "labPatientID";
            this.dgvPatientID.HeaderText = "Patient ID";
            this.dgvPatientID.Name = "dgvPatientID";
            this.dgvPatientID.ReadOnly = true;
            // 
            // dgvPatientName
            // 
            this.dgvPatientName.DataPropertyName = "labPatientName";
            this.dgvPatientName.HeaderText = "Patient Name";
            this.dgvPatientName.Name = "dgvPatientName";
            this.dgvPatientName.ReadOnly = true;
            this.dgvPatientName.Width = 120;
            // 
            // dgvAppointmentDate
            // 
            this.dgvAppointmentDate.DataPropertyName = "labAppointmentDate";
            this.dgvAppointmentDate.HeaderText = "Date";
            this.dgvAppointmentDate.Name = "dgvAppointmentDate";
            this.dgvAppointmentDate.ReadOnly = true;
            // 
            // dbvAppointmentDelete
            // 
            this.dbvAppointmentDelete.HeaderText = "Delete";
            this.dbvAppointmentDelete.Image = global::LabManagement.Properties.Resources.cancel_25px;
            this.dbvAppointmentDelete.Name = "dbvAppointmentDelete";
            this.dbvAppointmentDelete.ReadOnly = true;
            this.dbvAppointmentDelete.Width = 60;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tabCtrlPReg_App);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabCtrlPReg_App.ResumeLayout(false);
            this.tabPRegister.ResumeLayout(false);
            this.tabPRegister.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBxSelectApmnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRemove)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlPReg_App;
        private System.Windows.Forms.TabPage tabPRegister;
        private System.Windows.Forms.PictureBox pboxAdd;
        private System.Windows.Forms.PictureBox pboxRemove;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ListBox lstPTests;
        private System.Windows.Forms.ListBox lstTests;
        private System.Windows.Forms.TextBox txtPSearchTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateAppDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAppointmentList;
        private System.Windows.Forms.Button btnSetAppmnt;
        private System.Windows.Forms.GroupBox gBxSelectApmnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetAppLimit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSetAppointmenToday;
        private System.Windows.Forms.Button btnSearchAppmntByDate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbLPGenderUpdate;
        private System.Windows.Forms.TextBox txtLPEmailUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLPPhoneUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLPAgeUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLPNameUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLPUpdateCancel;
        private System.Windows.Forms.Button btnLPUpdate;
        private System.Windows.Forms.DateTimePicker dateLPAppDateUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAppointmentDate;
        private System.Windows.Forms.DataGridViewImageColumn dbvAppointmentDelete;
    }
}