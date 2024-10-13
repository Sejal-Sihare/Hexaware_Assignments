using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public class ProductService : IProductService
    {

        IProductRepository _productRepository;

        public ProductService( ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool createProduct(Products product)
        {
            return _productRepository.createProduct(product);
        }

        public bool deleteProduct(int Product_ID)
        {
            return _productRepository.deleteProduct(Product_ID);
        }
    }
}
