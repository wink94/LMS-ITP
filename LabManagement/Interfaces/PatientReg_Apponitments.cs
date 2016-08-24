using System;
using System.Data;
using System.Windows.Forms;
using LabManagement.Controllers;
using LabManagement.DBAccess;
using LabManagement.Interfaces;

namespace LabManagement
{
    public partial class Form2 : Form
    {
        private DBRetrieve dbr = new DBRetrieve();
        private LabPatient labPatient = new LabPatient();
        private LabAppointment labappmnt = new LabAppointment();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillTestSearch();
            FillGendercmbBox();
            displayTodayAppointmentcount(DateTime.Now);
            gBxSelectApmnt.Hide();
            //MessageBox.Show(dbr.getAppointmentLimit.ToString());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
                   
            Validation validation=new Validation();
            if (validation.alphaVal(txtPName.Text) & validation.IsNumeric(txtPAge.Text) & validation.numberVal(txtPPhone.Text) & validation.emailVal(txtPEmail.Text) & validation.checkTestListEmpty(labPatient) &validation.checkFieldIsSet(labappmnt.Adate,"Lab Appointment"))
            {
                labPatient.setDetails(txtPName.Text, cmbGender.SelectedValue.ToString(), txtPEmail.Text, txtPPhone.Text, Convert.ToInt32(txtPAge.Text));
               
                LabPatientBill lpb = new LabPatientBill(labPatient,labappmnt);
                lpb.ShowDialog();
                //this.Dispose();

                if (lpb.appoinmentStatus)
                {
                    lpb.Dispose();
                    emptyFields();
                    labPatient.emptyTestList();
                    
                    tabCtrlPReg_App.SelectedIndex = 1;

                }
                else
                    lpb.Dispose();
                
            }
            else
                validation.printError(true);
        }

        private void emptyFields()
        {
            txtPAge.Text = "";
            txtPEmail.Text = "";
            txtPName.Text = "";
            txtPPhone.Text = "";
            txtPSearchTest.Text = "";
            cmbGender.SelectedIndex = 0;
        }


        /*  fill test list and  */

        private void FillTestSearch()
        {

            DataTable dt1 = dbr.getSearchedTestDetails(txtPSearchTest.Text);


            lstTests.ValueMember = "TestID";
            lstTests.DisplayMember = "TestName";
            lstTests.DataSource = dt1;

        }

        /*  set hoover effect to arrow buttons */

        private void txtPSearchTest_TextChanged(object sender, EventArgs e)
        {
            FillTestSearch();
        }

        private void pboxAdd_MouseHover(object sender, EventArgs e)
        {
            pboxAdd.BackgroundImage = Properties.Resources.blue_right_arrow_hoover;
        }

        private void pboxAdd_MouseLeave(object sender, EventArgs e)
        {
            pboxAdd.BackgroundImage = null;
        }

        private void pboxRemove_MouseHover(object sender, EventArgs e)
        {
            pboxRemove.BackgroundImage = Properties.Resources.blue_left_hoover;
        }

        private void pboxRemove_MouseLeave(object sender, EventArgs e)
        {
            pboxRemove.BackgroundImage = null;
        }

       


        /*  add tests to patient list */

        private void pboxAdd_Click(object sender, EventArgs e)
        {
            if (lstTests.SelectedIndex >= 0)
            {
                string id = lstTests.SelectedValue.ToString();


                if (!labPatient.findIfExist(id))
                {

                    getTestList gTL = new getTestList(id, labPatient.getSelectedFromList(id));
                    //testList.Add(gTL);
                    labPatient.getPatientTest(gTL);



                    try
                    {
                        lstPTests.DataSource = labPatient.tests;
                        lstPTests.ValueMember = "id";
                        lstPTests.DisplayMember = "name";
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    lstTests.ClearSelected();
                    lstPTests.ClearSelected();
                }

            }
           
        }

        /*  remove tests from patient list */

        private void pboxRemove_Click(object sender, EventArgs e)
        {
            if (lstPTests.SelectedIndex>=0)
            {
                labPatient.removeTest(lstPTests.SelectedIndex);
                lstPTests.ClearSelected();
            }
        }

        private void FillGendercmbBox()
        {
            string[] gender = { "","Male","Female"};

            cmbGender.DataSource = gender;
        }

        private void displayTodayAppointmentcount(DateTime dt)
        {
            string today = dt.ToString("yyyy-MM-dd");
            lblAppNum.Text = dbr.getAppointmentCount(today).ToString();
        }

        private void tabCtrlPReg_App_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlPReg_App.SelectedIndex == 0)
            {
                displayTodayAppointmentcount(DateTime.Now);
                gBxSelectApmnt.Hide();
            }
        }

        private void btnSetAppmnt_Click(object sender, EventArgs e)
        {
            if (gBxSelectApmnt.Visible == false)
                gBxSelectApmnt.Show();
            else
                gBxSelectApmnt.Hide();
        }

        private void btnSetAppLimit_Click(object sender, EventArgs e)
        {
            /*
             set appointment limit 
             admin right require
             
             */
        }

        private void btnSetAppmntToday_Click(object sender, EventArgs e)
        {
            string date= DateTime.Now.ToString("yyyy-MM-dd");

            if (labappmnt.isAppointmentAllowed(date))
                labappmnt.Adate=date;

        }

        private void dateAppDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dateAppDate.Value.ToString("yyyy-MM-dd");

            if (labappmnt.isAppointmentAllowed(date))
                labappmnt.Adate = date;
        }
    }
}
