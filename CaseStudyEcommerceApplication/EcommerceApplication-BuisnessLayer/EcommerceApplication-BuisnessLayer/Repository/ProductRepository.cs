using EcommerceApplication_Entity;
using System;
using DbUtilsEcommerceApplication;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool createProduct(Products product)
        {
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();
                string query = "insert into Products (Product_Id,Product_name,Price,Description,StockQuantity )" +
                    " values('" + product.Product_ID + "','" + product.Product_name + "','" + product.Price + "','" + product.Description + "','" + product.StockQuantity + "')";
                SqlCommand com = new SqlCommand(query, conn);
                int roweffect = com.ExecuteNonQuery();

                if (roweffect > 0)
                {
                    return true;

                }
                return false;
            }
        }

        public bool deleteProduct(int Product_ID)
        {
            using (var conn = DbUtil.getDBConnection())
            {
                conn.Open();

                string query = "delete from Products where Product_ID = '" + Product_ID + "'";
                SqlCommand command = new SqlCommand(query, conn);
                int rowcount = command.ExecuteNonQuery();

                if (rowcount > 0)
                {

                    return true;
                }

                return false;

            }
        }
    }
}
