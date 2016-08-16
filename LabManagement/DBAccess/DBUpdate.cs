using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LabManagement.Controllers;
using System.Windows.Forms;

namespace LabManagement.DBAccess
{
    class DBUpdate
    {

        private MySqlConnection conn;

        public DBUpdate()
        {
            conn = ConnectionManager.GetConnection();
        }
        /* update test table according according to update flag fieds 1=tesname 2=testprice 3=both*/

        public void updateLabTestData(LabTest lt,int updateFlag)
        {
            string query;

            try
            {
                conn.Open();

                if (updateFlag==1)
                    query = "update lab_test set labTestName ='"+lt.Name+"' where labTestId ='" + lt.ID+"'" ;
                else if (updateFlag == 2)
                    query = "update lab_test set labTestPrice ='" + lt.Price + "' where labTestId ='" + lt.ID + "'";
                else
                    query = "update lab_test set labTestName ='" + lt.Name + "',labTestPrice ='" + lt.Price + "' where labTestId ='" + lt.ID + "'";

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
