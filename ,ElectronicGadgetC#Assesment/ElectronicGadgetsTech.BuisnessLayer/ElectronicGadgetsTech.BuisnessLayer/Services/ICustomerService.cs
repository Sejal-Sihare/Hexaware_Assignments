using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public interface ICustomerService
    {
        void CalculateTotalOrders();
        void GetCustomerDetails();

        void UpdateCustomerInfo(int id, string newEmail, string newPhone, string newAddress);

        void NewCustomer(Customers customer);
    }
}
