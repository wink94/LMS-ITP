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

    }
}
