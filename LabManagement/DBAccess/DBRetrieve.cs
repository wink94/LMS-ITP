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
        /*get lasst patient's id*/
        public string getRegisteredPatientID()
        {
            string query= "SELECT max(labPatientID) FROM lms.lab_patient";
            string id="";
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                id = newCmd.ExecuteScalar().ToString();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return null;
            }

            conn.Close();
            return id;
        }

        /* get  appointment count on date */
        public int getAppointmentCount(string date)
        {
            string query = "SELECT count(labAppointmentID) FROM lab_appointment where labAppointmentDate='" + date+"'";
            int count=-1 ;
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                
                count = Convert.ToInt32(newCmd.ExecuteScalar());

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return -1;
            }

            conn.Close();
            return count;
        }

        /*get appointment limit*/

        public int getAppointmentLimit()
        {
            string query = "SELECT appointment_limit,max(ID) FROM lab_appointment_limit";
            int count = -1;
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);

                count = Convert.ToInt32(newCmd.ExecuteScalar());

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return -1;
            }

            conn.Close();
            return count;
        }

        /* populate datagridview with appointment details*/

        public DataSet getAppointmentDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            string query = "SELECT la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate FROM lab_patient lp, lab_appointment la WHERE lp.labPatientID = la.labPatientID ";
            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "lab_appointments");
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
