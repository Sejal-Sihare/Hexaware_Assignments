using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
    public interface IProductRepository
    {
        void GetProductDetails(Products product);

        void ProductRecommendation();

        void UpdateProductInfo(Products product, string newDescription, decimal newPrice);

        bool IsProductInStock(Inventory inventory);

        void UpdateProductDetails(Products products, string newDescription, decimal newPrice);
        
    }
}
