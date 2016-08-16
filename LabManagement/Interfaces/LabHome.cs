using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using LabManagement.DBAccess;

namespace LabManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showSystemDateTime(true);
            //DBInsert a = new DBInsert();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void showSystemDateTime(bool show)
        {
            if (show)
            {
                DateTime dt = DateTime.Parse(DateTime.Today.ToString());
                label6.Text = DateTime.Now.ToString("yyyy-MM-dd");
                
                Timer tmr = new Timer();
                tmr.Interval = 1000;//ticks every 1 second
                tmr.Tick += new EventHandler(tmr_Tick);
                tmr.Start();
            }
            
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            int hrs= Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (hrs > 12)
                time += " PM";
            else
                time += " AM";

            label5.Text = time;

        }
    }
}
