using System;
using LabManagement.DBAccess;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabManagement.Controllers
{
    class LabAppointment
    {
        private string LAID;
        private string LADate;
        private string PatinetID;
        private DBRetrieve dbr=new DBRetrieve();


        public string Adate { get { return LADate; } set { LADate = value; } }
        public string AID { get { return LAID; } set { LAID = value; } }
        public string PID{ get { return PatinetID; } set { PatinetID = value; }}
        //public string LAdate { get { return LADate; } }

       /* LabAppointment(DateTime dt)
        {
            LADate = dt.ToString("yyyy-MM-dd");
            //this.time = time.ToString("HH:mm:ss");
        }*/
        /*check if apponiment allowed on date */
        public bool isAppointmentAllowed(string date)
        {
            if (dbr.getAppointmentCount(date) >= dbr.getAppointmentLimit() || DateTime.Compare(DateTime.Parse(date),DateTime.Now)<0)
            {
                MessageBox.Show("Appointment is not allowed on "+date+" please Select an appointment date");
                return false;    
            }

            else
                return true;
        }


        /* delete lab appointment from appointment id*/
        public bool deleteLabAppointment()
        {
            string query;
            MySqlConnection conn  = ConnectionManager.GetConnection();

            try
            {
                conn.Open();
                query = "delete from lab_appointment  where labAppointmentID ='" + Convert.ToInt32(AID) + "'";
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


        /* update lab appointment from appointment id*/
        public void updateLabAppointmentDate()
        {
            string query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();

                query = "UPDATE lab_appointment SET labAppointmentDate ='" + Adate + "' WHERE labAppointmentID ='" + Convert.ToInt32(AID) + "'";
                

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
