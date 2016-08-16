using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class BloodTest
    {
        private int BTNo;
        private int sugar;
        private Dictionary<string,int> cellCount=new Dictionary<string, int>() { { "RBC",0 }, { "WBC",0},{"PLATELETS",0} };


        public BloodTest(int sugar,int rbc,int wbc,int platelets)
        {
            this.sugar = sugar;
            cellCount["RBC"] = rbc;
            cellCount["WBC"] = wbc;
            cellCount["PLATELETS"] = platelets;
        }

    }
}
