using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_CustomException
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException():base("Product not Found") { }

        public ProductNotFoundException(string message) : base(message) { }

        public ProductNotFoundException(string message,Exception inner) : base(message, inner) { }

    }
}
