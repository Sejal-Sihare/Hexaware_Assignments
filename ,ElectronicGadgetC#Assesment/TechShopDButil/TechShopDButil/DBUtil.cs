using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShopDButil
{
    public  static class DBUtil
    {

        public static SqlConnection getDBConnection()
        {
            SqlConnection conn;
            string connectionstring = "Data Source=LAPTOP-J8HVGTPS\\SQLEXPRESS;Initial Catalog=TechShop;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            return conn;
        }
    }
}
