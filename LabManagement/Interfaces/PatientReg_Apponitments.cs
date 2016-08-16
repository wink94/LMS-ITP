using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManagement.Controllers;
using LabManagement.DBAccess;

namespace LabManagement
{
    public partial class Form2 : Form
    {
        private DBRetrieve dbr = new DBRetrieve();
        private DBInsert dbi = new DBInsert(); 
       
        private LabPatient labPatient=new LabPatient();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillTestSearch();
            FillGendercmbBox();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Validation validation=new Validation();
            if (validation.alphaVal(txtPName.Text) & validation.IsNumeric(txtPAge.Text) & validation.numberVal(txtPPhone.Text) & validation.emailVal(txtPEmail.Text))
            {
                labPatient.setDetails(txtPName.Text, cmbGender.SelectedValue.ToString(), txtPEmail.Text, txtPPhone.Text, Convert.ToInt32(txtPAge.Text));
                dbi.insertLabPatient(labPatient);
            }
            else
                validation.printError(true);
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
            string[] gender = { "Male","Female"};

            cmbGender.DataSource = gender;
        }

    }
}
