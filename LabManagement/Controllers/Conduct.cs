using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class Conduct
    {
        private string testID;
        private int patientID;
        private bool status;

        public Conduct(string testID,int patientID,bool status)
        {
            this.testID = testID;
            this.patientID = patientID;
            this.status = status;
        }

    }

}
