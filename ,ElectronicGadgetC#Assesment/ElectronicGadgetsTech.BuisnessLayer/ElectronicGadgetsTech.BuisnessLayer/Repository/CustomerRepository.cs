using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicGadgetsTech.Entity;
using TechShopDButil;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{

    public class CustomerRepository : ICustomerRepository
    {
        int CustomerID;
        string FirstName;
        string LastName;
        string Email;
        string Phone;
        string Address;
        public void CalculateTotalOrders()
        {
            Console.WriteLine("The total orders by the Customer is 1");
        }

        public void UpdateCustomerInfo(int id, string newEmail, string newPhone, string newAddress)
        {
            
            try
            {
                DBUtil.getDBConnection().Open();

                //fire query
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Customers set Email='" + newEmail + "',Phone ='" + newPhone + "',Address = '" + newAddress + "' where CustomerID='" + id + "'";
                cmd.Connection = DBUtil.getDBConnection();
                int count = cmd.ExecuteNonQuery();
                

                
                //close the connection
                 DBUtil.getDBConnection().Close();

                Console.WriteLine("The Customer Information After Updation is:");
                GetCustomerDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {

                DBUtil.getDBConnection().Close();
            }

        }

        public void GetCustomerDetails()
        {
            var conn = DBUtil.getDBConnection();
            conn.Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Customers";
            cmd.Connection = conn;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            Console.WriteLine("CustomerID\tFirstName\tLastName\tEmail\tPhone\tAddress");
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader[0] + "\t\t " + sqlDataReader[1]

                    + "\t \t " + sqlDataReader[2] + "\t\t " + sqlDataReader[3] + "\t\t " + sqlDataReader[4] + "\t\t " + sqlDataReader[5]);
            }
            sqlDataReader.Close();

          
            conn.Close();


        }
        //New Customer addition
        public void NewCustomer(Customers customer)
        {
            DBUtil.getDBConnection().Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Customers values('" + customer.CustomerID + "','" + customer.FirstName + "','" + customer.LastName+ "','" + customer.Email+ "','"+customer.Phone+"','"+customer.Address+"')"; 
            cmd.Connection = DBUtil.getDBConnection();
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                Console.WriteLine("\n \n New Customer Added");
            }
            //close the connection
            DBUtil.getDBConnection().Close();

            
        }

    }
    }


