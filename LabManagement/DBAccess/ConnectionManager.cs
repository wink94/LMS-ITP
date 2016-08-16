using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace LabManagement.DBAccess
{
   public class ConnectionManager
    {
        public static MySqlConnection NewCon;
        //public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        private static string ConStr2 = "SERVER=localhost; DATABASE=lms; UID=root; PASSWORD=123456";
        public static MySqlConnection GetConnection()
        {
            NewCon = new MySqlConnection(ConStr2);
            
            return NewCon;
        }

    }
}
