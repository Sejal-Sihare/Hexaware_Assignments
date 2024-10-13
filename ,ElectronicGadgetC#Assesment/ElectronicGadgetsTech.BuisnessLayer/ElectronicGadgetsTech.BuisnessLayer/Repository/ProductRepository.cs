using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShopDButil;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
 public class ProductRepository : IProductRepository
    {

        int ProductID;
        string ProductName;
        string Description;
        decimal Price;

      public List<Products>Availableforsale;

        public void GetProductDetails(Products product)
        {
            Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}");
        }

        public void ProductRecommendation()
        {
            var conn = DBUtil.getDBConnection();
            conn.Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Products";
            cmd.Connection = conn;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            Console.WriteLine("ProductID\tProductName\tDescription\tPrice ");
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader[0] + "\t\t " + sqlDataReader[1]

                    + "\t \t " + sqlDataReader[2] + "\t\t " + sqlDataReader[3] );
            }
            sqlDataReader.Close();

           
            conn.Close();
        }

        public bool IsProductInStock(Inventory inventory)
        {
            return inventory.QuantityInStock > 0;

        }

        public void UpdateProductInfo(Products product, string newDescription, decimal newPrice)
        {
            product.Description = newDescription;
            product.Price = newPrice;
        }

        public void UpdateProductDetails(Products product, string newDescription, decimal newPrice)
        {
            //open the connection
            DBUtil.getDBConnection().Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Products set Description='" + newDescription + "',Price ='" + newPrice + "' where ProductID='" + product.ProductID + "'";
            cmd.Connection = DBUtil.getDBConnection();
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                Console.WriteLine("\n \n  Product details updated");
            }
            //close the connection
            DBUtil.getDBConnection().Close();

           

        }

      
    }
}
