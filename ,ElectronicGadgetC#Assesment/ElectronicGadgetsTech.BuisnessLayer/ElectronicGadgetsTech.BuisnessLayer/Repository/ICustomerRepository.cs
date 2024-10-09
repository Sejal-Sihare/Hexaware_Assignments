using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicGadgetsTech.Entity;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
   public  interface ICustomerRepository
    {
       void CalculateTotalOrders();
         void GetCustomerDetails();

        void UpdateCustomerInfo(int id, string newEmail, string newPhone, string newAddress);

        void NewCustomer(Customers customer);

    }
}
