using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public class CustomerService : ICustomerService
    {

        ICustomerRepository _customerRepository;
        public CustomerService( CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public bool deleteCustomer(int Customer_ID)
        {
           return  _customerRepository.deleteCustomer(Customer_ID);
        }

        public void getAllCustomer()
        {
           _customerRepository.getAllCustomer();
        }
         public bool createCustomer(Customers customer)
        {
            return _customerRepository.createCustomer(customer);
        }
    }
}
