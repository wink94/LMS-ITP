using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManagement.DBAccess;

namespace LabManagement.Controllers
{
    class LabPatient
    {
        private string patientID;
        private int patientAge;
        private string patientName;
        private string patientGender;
        private string patientEmail;
        private string patientTelephone;
        private BindingList<getTestList> testList = new BindingList<getTestList>();
        private DBRetrieve dbr = new DBRetrieve();

        public string ID { get { return patientID; } }
        public int Age { get { return patientAge; } }
        public string Name { get { return patientName; } }
        public string Gender { get { return patientGender; } }
        public string Email { get { return patientEmail; } }
        public string Phone { get { return patientTelephone; } }
        public BindingList<getTestList> tests { get { return testList; } }

        public void setDetails(string PatientName, string PatientGender, string PatientEmail, string PatientTelephone,int PatientAge)
        {
            patientName = PatientName;
            patientGender = PatientGender;
            patientEmail = PatientEmail;
            patientTelephone = PatientTelephone;
            patientAge = PatientAge;
        }

        public void getPatientTest(getTestList gTL)
        {
            testList.Add(gTL);
        }


        /*  check test-id exist in binding list */

        public bool findIfExist(string id)
        {
            foreach (getTestList gTL in testList)
            {
                if (gTL.id == id)
                    return true;

            }
            return false;
        }


        /*  add tests to patient lists */

        public string getSelectedFromList(string id)
        {
            DataTable dt2 = dbr.getSearchedTestDetails();
            DataRow[] arr;
            string qry = "TestID='" + id + "'";
            arr = dt2.Select(qry);


            return arr[0][1].ToString();

        }

        /*  remove tests from patient list */

        public bool removeTest(int index)
        {
            if (testList.Count > 0 )
            {
                testList.RemoveAt(index);
                return true;
            }
            return false;
            
        }

        public bool checkTestListEmpty()
        {
            return testList.Count > 0;
        }

        public void emptyTestList()
        {
            for(int i = 0; i < testList.Count; i++)
            {
                testList.RemoveAt(i);
            }
        }

        public bool setPatientID()
        {
            patientID = dbr.getRegisteredPatientID();
            return (patientID == null || patientID == "") ? false : true;
        }


    }
}
