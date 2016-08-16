using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class CholosterolTest
    {
        private int CTNo;
        private int HDL;
        private int LDL;
        
        public CholosterolTest(int HDL,int LDL)
        {
            this.HDL = HDL;
            this.LDL = LDL;
        } 
    }
}
