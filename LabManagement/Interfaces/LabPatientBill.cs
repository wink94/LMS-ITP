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

namespace LabManagement.Interfaces
{
    public partial class LabPatientBill : Form
    {
        private LabPatient lp = new LabPatient();
        private LabAppointment la = new LabAppointment();
        private DBInsert dbi = new DBInsert();
        private DBRetrieve dbr = new DBRetrieve();
        private bool appState;
        
        public bool appoinmentStatus
        { get { return appState; } }
        

        public LabPatientBill()
        {
            InitializeComponent();

        }
        public LabPatientBill(object lp1,object la1) :this()
        {
            InitializeComponent();
            lp = (LabPatient)lp1;
            la = (LabAppointment)la1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbi.insertLabPatient(lp);

            string LPID=dbr.getRegisteredPatientID();  //get enterd labpatients id
           
            la.PID = LPID;
            dbi.insertLabAppointment(la);
            dbi.insertTestListData(LPID, lp.tests.ToList());

            /*  
              
             print report handles here


             */
            

            appState = true;
            this.Hide();

        }

        private void LabPatientBill_Load(object sender, EventArgs e)
        {
            /*

            display report

            */
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appState = false;
            this.Hide();
        }
    }
}
