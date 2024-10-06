using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicGadgetShop.Entity;

namespace ElectronicGadgetShop.BuisnessLayer
{
    public class CustomerBuisness
    {

        public int CustomerID;
        public string FirstName;
        public string LastName;
         public string Email;
        public string Phone;
        public string Address;

        public void CalculateTotalOrders()
        {
            Console.WriteLine("The total orders by the Customer is 1" );
        }

        public void GetCustomerDetails( Customers customer)
        {
            
      Console.WriteLine($"Customer ID: {customer.CustomerID}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");
        }

        public void UpdateCustomerInfo(Customers customer, string newEmail, string newPhone, string newAddress)
        {
           customer.Email = newEmail;
            customer. Phone = newPhone;
             customer .Address = newAddress;
        }
    }

   
    }


 

   
