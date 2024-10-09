using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public decimal CalculateTotalAmount(Orders order)
        {
            return order.TotalAmount;
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order is Canceled");
        }

        public void GetOrderDetails(Orders order, Customers customer)
        {
            Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate}, Customer: {order.Customer.FirstName} {order.Customer.LastName}");
        }

        public void UpdateOrderStatus(Orders order)
        {
            order.OrderDate = DateTime.Now;
        }
    }
}
