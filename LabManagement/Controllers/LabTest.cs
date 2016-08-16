using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LabManagement.DBAccess;
using System.Windows.Forms;

namespace LabManagement.Controllers
{
    class LabTest
    {
        private string testID;
        private string testName;
        private double testPrice;
        private DBUpdate dbu = new DBUpdate();
        private DBDelete dbd = new DBDelete();

        public string ID { get { return testID; } }
        public string Name { get { return testName; } set { testName = value; } }
        public double Price { get { return testPrice; } set { testPrice = value; } }

        /* seaarch test method*/

        public bool searchTestByID(string test)
        {

            string pattern = @"^LT[0-9]+$";
            Match m = Regex.Match(test, pattern);

            return (m.Success && test.Length <= 5);
         
        }

        public void setUpdateTest(string testid,string testname,double testprice)
        {
            testID = testid;
            testName = testname;
            testPrice = testprice;
        }
        public void updateTest(int updateFlag)
        {
            dbu.updateLabTestData(this, updateFlag);
        }


        public void removeTest()
        {
            if (!dbd.deleteLabTest(this))
            {
                testID = "";
                testName = "";
                testPrice = -1;
            }
        }
        
    }
}
