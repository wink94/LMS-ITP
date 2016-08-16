using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManagement.DBAccess;
using LabManagement.Controllers;

namespace LabManagement.Interfaces
{
    public partial class ManageTest : Form
    {
        private DBRetrieve dbr = new DBRetrieve();
        private DBUpdate dbu = new DBUpdate();
        private LabTest labtest = new LabTest();

        public ManageTest()
        {
            InitializeComponent();
        }

        private void ManageTest_Load(object sender, EventArgs e)
        {
            FillTest();
        }

        /*  fill test details  */

        private void FillTest()
        {

            DataSet ds = dbr.getLabTest();
            dgvTests.DataSource = ds.Tables["labtests"].DefaultView;
            
        }

        private void FillSearchTest(string test)
        {
            try
            {
                DataSet ds = dbr.getSearcehdLabTest(txtTestSearch.Text);
                dgvTests.DataSource = ds.Tables["searchtests"].DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtTestSearch_TextChanged(object sender, EventArgs e)
        {
            FillSearchTest(txtTestSearch.Text);
        }


        private void getGridData(int rowid)
        {

            string testID,testName,testPrice;
            
            testID = dgvTests.Rows[rowid].Cells["dgvTestID"].Value.ToString();
            testName = dgvTests.Rows[rowid].Cells["dgvTestName"].Value.ToString();
            testPrice = dgvTests.Rows[rowid].Cells["dgvTestPrice"].Value.ToString();


            labtest.setUpdateTest(testID,testName,Convert.ToDouble(testPrice));
            
            
        }

        private void fillTestData()
        {
            lblTestID.Text = labtest.ID;
            txtTestName.Text = labtest.Name;
            txtTestPrice.Text = labtest.Price.ToString();
        }

        private void emptyFields()
        {
            lblTestID.Text = "";
            txtTestName.Text = "";
            txtTestPrice.Text = "";
        }

        private void dgvTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
                return;
            else if (e.ColumnIndex==dgvDel.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    getGridData(e.RowIndex);
                    fillTestData();
                    labtest.removeTest();
                    emptyFields();
                    FillTest();
                }
                else if (dialogResult == DialogResult.No)
                {
                    emptyFields();
                }
            }
            else
            {
                getGridData(e.RowIndex);
                fillTestData();
            }
        }

        private void updateConfirm()
        {
            string tstName = txtTestName.Text, tstPrice = txtTestPrice.Text;
            int updateFlag ;
           
            Validation vali = new Validation();

            if (tstName != labtest.Name && tstPrice != labtest.Price.ToString() && vali.IsNumeric(tstPrice) && vali.alphaNumericVal(tstName))
            {
                labtest.Name = tstName;
                labtest.Price = Convert.ToDouble(tstPrice);
                updateFlag = 3;
            }
            else if (tstName != labtest.Name && vali.alphaNumericVal(tstName) && vali.IsNumeric(tstPrice))
            {
                labtest.Name = tstName;
                updateFlag = 1;
            }
            else if (tstPrice != labtest.Price.ToString() && vali.IsNumeric(tstPrice) && vali.alphaNumericVal(tstName))
            {
                labtest.Price = Convert.ToDouble(tstPrice);
                updateFlag = 2;
            }
            else
            {
                vali.printError(true);
                updateFlag = 0;
            }

            if (updateFlag>0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?","Update Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labtest.updateTest(updateFlag);
                }
                else if (dialogResult == DialogResult.No)
                {
                    emptyFields();
                }
            }

        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
        {
            updateConfirm();
            FillTest();
        }
    }
}
