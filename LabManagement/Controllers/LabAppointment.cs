using System;
using LabManagement.DBAccess;
using System.Windows.Forms;

namespace LabManagement.Controllers
{
    class LabAppointment
    {
        private int LAID;
        private string LADate;
        private string PatinetID;
        private DBRetrieve dbr=new DBRetrieve();


        public string Adate { get { return LADate; } set { LADate = value; } }
        public int AID { get { return LAID; } }
        public string PID{ get { return PatinetID; } set { PatinetID = value; }}
        //public string LAdate { get { return LADate; } }

       /* LabAppointment(DateTime dt)
        {
            LADate = dt.ToString("yyyy-MM-dd");
            //this.time = time.ToString("HH:mm:ss");
        }*/

        public bool isAppointmentAllowed(string date)
        {
            if (dbr.getAppointmentCount(date) >= dbr.getAppointmentLimit())
            {
                MessageBox.Show("Appointment limit exceeded "+date+" please Select an appointment date");
                return false;    
            }

            else
                return true;
        }

        

    }
}
