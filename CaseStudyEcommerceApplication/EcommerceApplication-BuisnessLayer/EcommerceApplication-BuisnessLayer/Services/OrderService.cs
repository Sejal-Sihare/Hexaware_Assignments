using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public class OrderService:IOrderService
    {
        IOrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository) {
            _orderRepository = orderRepository;

        }

        public List<Products> getOrderByCustomer(int Customer_ID)
        {
            return _orderRepository.getOrderByCustomer(Customer_ID);
        }

        public bool placeOrder(Orders order)
        {
            return _orderRepository.placeOrder(order);
        }
    }
}
