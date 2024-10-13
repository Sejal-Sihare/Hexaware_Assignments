using ElectronicGadgetsTech.BuisnessLayer.Repository;
using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public class ProductService: IProductService
    {
       IProductRepository _productRepository;

        public ProductService( IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void GetProductDetails(Products product)
        {
            _productRepository.GetProductDetails(product);
        }

        public void ProductRecommendation()
        {
            _productRepository.ProductRecommendation();
        }
        public bool IsProductInStock(Inventory inventory)
        {
          return _productRepository.IsProductInStock(inventory);

        }

        public void UpdateProductInfo(Products product, string newDescription, decimal newPrice)
        {
           _productRepository.UpdateProductInfo(product, newDescription, newPrice);
        }

        public void  UpdateProductDetails(Products product, string newDescription, decimal newPrice)
        {
            _productRepository.UpdateProductDetails(product, newDescription, newPrice);
        }
    }
}
