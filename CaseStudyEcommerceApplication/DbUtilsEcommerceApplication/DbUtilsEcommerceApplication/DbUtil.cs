using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DbUtilsEcommerceApplication
{
    public static  class DbUtil
    {
        public static SqlConnection getDBConnection()
        {
           SqlConnection conn;
          //  string connectionstring = "Data Source=LAPTOP-J8HVGTPS\\SQLEXPRESS;Initial Catalog=NewEcommerceApplication;Integrated Security=True;TrustServerCertificate=True";

            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyCasestudyConnections"].ConnectionString;
           
            return conn;
        }
    }
}
