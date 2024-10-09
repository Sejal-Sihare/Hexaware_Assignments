using ElectronicGadgetsTech.BuisnessLayer.Repository;
using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public class OrderDetailService
    {

        IOrderDetailRepository _orderDetailRepository;

        OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

       decimal CalculateSubtotal(Products product, OrderDetails orderdetail)
        {
            return _orderDetailRepository.CalculateSubtotal(product, orderdetail);
        }

        public void GetOrderDetailInfo(OrderDetails orderDetail)
        {
           _orderDetailRepository.GetOrderDetailInfo(orderDetail);
        }

        public void UpdateQuantity(OrderDetails orderdetail, int newQuantity)
        {
          _orderDetailRepository.UpdateQuantity(orderdetail, newQuantity);
        }

        public void AddDiscount(decimal discountAmount)
        {
           _orderDetailRepository.AddDiscount(discountAmount);
        }

    }
}
