using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using LabManagement.Controllers;

namespace LabManagement.DBAccess
{
    class DBInsert
    {
        MySqlConnection conn;
        public DBInsert()
        {
                conn = ConnectionManager.GetConnection();
        }

        /*insert patient details to DB*/
        public void insertLabPatient(LabPatient lp)
        {
            string query;

            try
            {
                conn.Open();

                query = "insert into lab_patient(labPatientName,labPatientAge,labPatientGender,labPatientEmail,labPatientPhone) values('"+lp.Name+"','"+lp.Age+"','"+lp.Gender+"','"+lp.Email+"','"+lp.Phone+"')";

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }
        /*insert lab appointmetn details to DB*/
        public void insertLabAppointment(LabAppointment la)
        {
            string query;

            try
            {
                conn.Open();
                
                query = "insert into lab_appointment(labAppointmentDate,labPatientID) values('" + la.Adate+ "','" + Convert.ToInt32(la.PID)+"' )";

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }


        public void insertTestListData(string pid, List<getTestList> lst)
        {
            try
            {
                conn.Open();
               
                string query = "";
                foreach (getTestList gtl in lst)
                {
                    query += "insert into lab_test_result(labPatientID,labTestID) values (" + Convert.ToInt32(pid) + ",'" + gtl.id + "');";
                }

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }


    }
}
