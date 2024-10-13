using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceApplication_Entity;

namespace EcommerceApplication_BuisnessLayer.Repository
{
    public interface ICustomerRepository
    {
        bool createCustomer(Customers customer);
        bool deleteCustomer(int Customer_ID);

        void getAllCustomer();

    }
}
