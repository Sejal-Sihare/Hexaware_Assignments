using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicGadgetsTech.Entity;
using ElectronicGadgetsTech.BuisnessLayer.Repository;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public class InventoryService:IInventoryService
    {
        IInventoryRepository _inventoryRepository;

        InventoryService(IInventoryRepository inventoryRepository) { 
        
            _inventoryRepository = inventoryRepository;
        }
        public void AddToInventory(Inventory inventory, int quantity)
        {
           _inventoryRepository.AddToInventory(inventory, quantity);
        }

        public void RemoveFromInventory(Inventory inventory)
        {
            _inventoryRepository.RemoveFromInventory(inventory);


        }

        public void UpdateStockQuantity(Inventory inventory, int newQuantity)
        {
            _inventoryRepository.UpdateStockQuantity(inventory, newQuantity);
        }

        public bool IsProductAvailable(Inventory inventory, int quantityToCheck)
        {
            return _inventoryRepository.IsProductAvailable(inventory, quantityToCheck);
        }

        public decimal GetInventoryValue(Inventory inventory, Products Product)
        {
            return _inventoryRepository.GetInventoryValue(inventory, Product);
        }
        public void InventoryDetails()
        {
            _inventoryRepository.InventoryDetails();
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
