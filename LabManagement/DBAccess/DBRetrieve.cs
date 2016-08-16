using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LabManagement.Controllers;

namespace LabManagement.DBAccess
{
    class DBRetrieve
    {

        private MySqlConnection conn;

        public DBRetrieve()
        {
            conn = ConnectionManager.GetConnection();
        }



        /*  retrieve test details from db */

        public DataTable getSearchedTestDetails(string testName = null)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TestID", typeof(string));
            dt.Columns.Add("TestName", typeof(string));
            string query;

            try
            {
                conn.Open();

                if(testName!=null || testName!=" ")
                    query = "select labTestID,labTestName from lab_test where labTestName like '%" + testName + "%'";
                else
                    query = "select labTestID,labTestName from lab_test";

                MySqlCommand newCmd = new MySqlCommand(query, conn);        
                MySqlDataReader dr = newCmd.ExecuteReader(); 

                while (dr.Read())
                {
                    dt.Rows.Add(dr["labTestID"], dr["labTestName"]);        //read retrived data row wise
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();
            return dt;
        }

        /* populate datagridview with test details*/

        public DataSet getLabTest()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            string query = "select * from lab_test";
            MySqlCommand newCmd = new MySqlCommand(query, conn);
            
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "labtests");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }

        /* get lab  test by test id or test name by search key word*/
        public DataSet getSearcehdLabTest(string test=null)
        {
            string query;
            LabTest labtest = new LabTest();

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            if(labtest.searchTestByID(test))
                query = "select * from lab_test where  labTestID like '%" + test + "%'";
            else
                query = "select * from lab_test where  labTestName like '%" + test + "%'";

            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "searchtests");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }


    }
}
