using ElectronicGadgetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetShop.BuisnessLayer
{
    public class InventoryService
    {
        public void AddToInventory(Inventory inventory,int quantity)
        {
            inventory.QuantityInStock += quantity;
            inventory.LastStockUpdate = DateTime.Now;
        }

        public void RemoveFromInventory(Inventory inventory,int quantity)
        {
            if (inventory.QuantityInStock >= quantity)
            {
                inventory.QuantityInStock -= quantity;
                inventory.LastStockUpdate = DateTime.Now;
            }
            else
            {
                throw new Exception("Not enough stock to remove the specified quantity.");
            }
        }

        public void UpdateStockQuantity(Inventory inventory,int newQuantity)
        {
            inventory.QuantityInStock = newQuantity;
            inventory.LastStockUpdate = DateTime.Now;
        }

        public bool IsProductAvailable( Inventory inventory,int quantityToCheck)
        {
            return inventory.QuantityInStock >= quantityToCheck;
        }

        public decimal GetInventoryValue(Inventory inventory,Products Product)
        {
            return inventory.Product.Price * inventory.QuantityInStock;
        }

       /* public List<Products> ListLowStockProducts(List<Inventory> inventories, int threshold)
        {
            return inventories.Where(i => i.QuantityInStock < threshold).Select(i => i.Product).ToList();
        }

        public List<Products> ListOutOfStockProducts(List<Inventory> inventories)
        {
            return inventories.Where(i => i.QuantityInStock == 0).Select(i => i.Product).ToList();
        }

        public List<Products> ListAllProducts(List<Inventory> inventories)
        {
            return inventories.Select(i => i.Product).ToList();
        }*/
    }
}

