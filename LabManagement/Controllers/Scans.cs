using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class Scans
    {
        private int SNo;
        private bool CT;
        private bool MRI;
        private bool UltraSound;

        public Scans(bool ct,bool mri,bool US)
        {
            CT = ct;
            MRI = mri;
            UltraSound = US;
        }
    }
}
