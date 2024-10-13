using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public interface IProductService
    {
        bool createProduct(Products product);

        bool deleteProduct(int Product_ID);
    }
}
