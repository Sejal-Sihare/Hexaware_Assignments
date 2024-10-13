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
    public class CartRepository : ICartRepository
    {
        public bool addToCart(int Cart_ID, Products product, Customers customer, int Quantity)
        {
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();
                string query = "insert into Cart ( Cart_ID,Customer_ID,Product_ID,Quantity) values('" + Cart_ID + "', '" + customer.Customer_ID + "','" + product.Product_ID + "','" + Quantity + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int roweffect = cmd.ExecuteNonQuery();

                if (roweffect > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
        }

        public List<Products> getAllFromCart( int Customer_ID)
        {
             List<Products> products = new List<Products>();
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();
                string query = "Select p.Product_ID,p.Product_name,p.Price,p.Description,c.Quantity from Cart c inner join Products p on c.Product_ID = p.Product_ID where c.Customer_ID = '" + Customer_ID + "'";
                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) {
                    //()
                    Products product = new Products()
                    {
                        Product_ID = reader.GetInt32(0),
                        Product_name = reader.GetString(1),
                        Price = reader.GetString(2),
                        Description = reader.GetString(3),
                        StockQuantity = reader.GetInt32(4)
                    };
                    products.Add(product); }
            }
            return products;
            }
            
        

        public bool removeFromCart(int Cart_ID)
        {
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();

                string query = "delete from Cart where Cart_ID = '" + Cart_ID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int roweffect = cmd.ExecuteNonQuery();

                if (roweffect > 0)
                {
                    return true;
                }
                return false;

            }
        }
    }
}
