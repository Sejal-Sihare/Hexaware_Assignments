using ElectronicGadgetsTech.BuisnessLayer.Repository;
using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository _orderRepository ;

        OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public decimal CalculateTotalAmount(Orders order)
        {

           return  _orderRepository.CalculateTotalAmount(order);
        }

        public void GetOrderDetails(Orders order, Customers customer)
        {
             _orderRepository.GetOrderDetails(order, customer);
        }

        public void UpdateOrderStatus(Orders order)
        {
            _orderRepository.UpdateOrderStatus(order);

        }

        public void CancelOrder()
        {

            _orderRepository.CancelOrder();
        }
    }
}
