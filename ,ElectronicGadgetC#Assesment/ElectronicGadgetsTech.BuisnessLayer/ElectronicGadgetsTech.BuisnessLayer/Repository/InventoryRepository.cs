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
    public class InventoryRepository : IInventoryRepository
    {
        public void AddToInventory(Inventory inventory, int quantity)
        {
            inventory.QuantityInStock += quantity;
            inventory.LastStockUpdate = DateTime.Now;
        }

            public decimal GetInventoryValue(Inventory inventory, Products Product)
        {
            return inventory.Product.Price * inventory.QuantityInStock;
        }

        public bool IsProductAvailable(Inventory inventory, int quantityToCheck)
        {
            return inventory.QuantityInStock >= quantityToCheck;
        }

        public void RemoveFromInventory(Inventory inventory)
        {
            DBUtil.getDBConnection().Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from employee where InventoryID='" +inventory.InventoryID + "'";
            cmd.Connection = DBUtil.getDBConnection();
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                Console.WriteLine("\n \n  Employee removed");
            }
            //close the connection
            DBUtil.getDBConnection().Close();

            Console.WriteLine("The Remaining Inventories after deletion are :");
            InventoryDetails();
        }

        public void UpdateStockQuantity(Inventory inventory, int newQuantity)
        {
            inventory.QuantityInStock = newQuantity;
            inventory.LastStockUpdate = DateTime.Now;
        }

        public void InventoryDetails()
        {
            var conn = DBUtil.getDBConnection();
            conn.Open();

            //fire query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Inventory";
            cmd.Connection = conn;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            Console.WriteLine("InventoryID\tProductID\tQuantityInStock\tLastStockUpdate ");
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader[0] + "\t\t " + sqlDataReader[1]

                    + "\t \t " + sqlDataReader[2] + "\t\t " + sqlDataReader[3] );
            }
            sqlDataReader.Close();

            
            conn.Close();
        }
    }
}
