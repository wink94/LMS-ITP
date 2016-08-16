using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace LabManagement.DBAccess
{
    class DBInsert
    {
        MySqlConnection conn;
        public DBInsert()
        {
            
                conn = ConnectionManager.GetConnection();
                conn.Open();
                
           
        }
    }
}
