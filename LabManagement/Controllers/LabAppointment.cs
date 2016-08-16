using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class LabAppointment
    {
        private int LAID;
        private DateTime LADate;
        private string time;


        public DateTime LAdate{ get { return LADate; } }

        LabAppointment(DateTime dt,string time)
        {
            LADate = dt;
            this.time = time;
        }

    }
}
