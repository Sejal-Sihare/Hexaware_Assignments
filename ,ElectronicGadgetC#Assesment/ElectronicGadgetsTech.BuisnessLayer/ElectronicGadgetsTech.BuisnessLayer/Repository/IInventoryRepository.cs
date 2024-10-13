using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
   public interface IInventoryRepository
    {
        void AddToInventory(Inventory inventory, int quantity);

        void RemoveFromInventory(Inventory inventory);

        void UpdateStockQuantity(Inventory inventory, int newQuantity);

        bool IsProductAvailable(Inventory inventory, int quantityToCheck);

        decimal GetInventoryValue(Inventory inventory, Products Product);

        void InventoryDetails();

      //  List<Products> ListLowStockProducts(List<Inventory> inventories, int threshold);

       // List<Products> ListOutOfStockProducts(List<Inventory> inventories);

       // List<Products> ListAllProducts(List<Inventory> inventories);
    }
}
