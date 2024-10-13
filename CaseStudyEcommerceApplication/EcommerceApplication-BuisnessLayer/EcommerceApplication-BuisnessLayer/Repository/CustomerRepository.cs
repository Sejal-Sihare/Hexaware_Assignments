using DbUtilsEcommerceApplication;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceApplication_CustomException;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;

namespace EcommerceApplication_BuisnessLayer.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool createCustomer(Customers customer)
        {
            using (var conn = DbUtil.getDBConnection())
            {
               conn.Open();

                //fire query
                string query= "insert into Customers (Customer_Id,Name,Email,Password)" +
                    " values('" + customer.Customer_ID +"','" + customer.Name + "','" + customer.Email + "','" + customer.Password + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    return true;
                }
                return false;
            }

        }



        public bool deleteCustomer(int Customer_ID)
        {
            bool status = false;
            


            using (var conn = DbUtil.getDBConnection())
            {

                conn.Open();
               
                string query = "delete from Customers where Customer_ID= '" + Customer_ID + "'";
                SqlCommand com = new SqlCommand(query, conn);
                int roweffect = com.ExecuteNonQuery();
                if (roweffect != 0)
                {
                    status = true;
                }

               
            }
            return status;
        }
       
        public void getAllCustomer()
        {
            using (var conn = DbUtil.getDBConnection())
            {
                 conn.Open();

                //fire query
                string query = "select * from Customers";

                SqlCommand cmd = new SqlCommand(query,conn);
               

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                Console.WriteLine("Customer ID\tCustomer Name\tCustomer Email\tCustomer Password ");

                //Console.WriteLine("Column Ordinal " + sqlDataReader.GetOrdinal("Emp_Name") + sqlDataReader.GetSqlString(0));
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader[0] + "\t\t " + sqlDataReader[1]

                        + "\t \t " + sqlDataReader[2] + "\t\t " + sqlDataReader[3]);
                }
               
            }
        }

    }
}

