using ElectronicGadgetsTech.BuisnessLayer.Repository;
using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
   public class CustomerService : ICustomerService
 {
        ICustomerRepository _customerRepository;
        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }

        public void CalculateTotalOrders()
        {
            _customerRepository.CalculateTotalOrders();
        }

        public void GetCustomerDetails()
        {
            _customerRepository.GetCustomerDetails();
        }

        public void UpdateCustomerInfo(int id, string newEmail, string newPhone, string newAddress)
        {
            _customerRepository.UpdateCustomerInfo( id, newEmail, newPhone, newAddress);
        }
        public void NewCustomer(Customers customer)
        {
            _customerRepository.NewCustomer( customer );
        }
    }
}
