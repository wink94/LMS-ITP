using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManagement.Controllers;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LabManagement.DBAccess
{
    class DBDelete
    {

        private MySqlConnection conn;

        public DBDelete()
        {
            conn = ConnectionManager.GetConnection();
        }

        /* delete test from test id*/
        public bool deleteLabTest(LabTest lt)
        {
            string query;

            try
            {
                conn.Open();
                query = "delete from lab_test  where labTestId ='" + lt.ID + "'";
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                conn.Close();
                return false;
            }
            
        }

        


        


    }
}
