using DbUtilsEcommerceApplication;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Products> getOrderByCustomer(int Customer_ID)
        {
            List<Products> products = new List<Products>();
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();

                string query = "select p.Product_ID,p.Product_name,p.Price,oi.QuantityOfOrderItems from OrderItems oi" +
                    " join Products p on oi.Product_ID = p.Product_Id join Orders o on oi.Order_ID = o.Order_ID where o.Customer_ID = '" + Customer_ID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Products product = new Products
                    {
                        Product_ID = reader.GetInt32(0),
                        Product_name = reader.GetString(1),
                        Price = reader.GetString(2),
                        StockQuantity = reader.GetInt32(3)
                    };

                    products.Add(product);
                }


            }
            return products;
        }


       public bool placeOrder(Orders order)
        {
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();
    string query = "insert into Orders (Order_Id,Customer_ID,OrderDate,TotalPrice,ShippingAddress) values( '" + order.Order_ID + "','" + order.Customer_ID + "','" + order.OrderDate + "','" + order.Total_Price + "','" + order.ShippingAddress + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowscount = cmd.ExecuteNonQuery();

                if (rowscount > 0)
                {
                    return true;
                }
                return false;

            }


        }

        
    }
}
