using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public interface ICustomerService
    {


        bool createCustomer(Customers customer);
        bool deleteCustomer(int Customer_ID);

        void getAllCustomer();
    }
}
