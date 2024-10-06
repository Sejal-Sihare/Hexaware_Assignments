using ElectronicGadgetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetShop.BuisnessLayer
{
   
        public class ProductService
        {
           

            public void GetProductDetails(Products product)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}");
            }

            public void UpdateProductInfo(Products product,string newDescription, decimal newPrice)
            {
                product.Description = newDescription;
                product.Price = newPrice;
            }

            public bool IsProductInStock(Inventory inventory)
            {
                return inventory.QuantityInStock > 0;
            }
        }

    }

