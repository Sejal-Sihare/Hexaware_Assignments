using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddDiscount(decimal discountAmount)
        {
            Console.WriteLine("The discount for this Product is Rupess 500");
        }

        public decimal CalculateSubtotal(Products product, OrderDetails orderdetail)
        {
            return orderdetail.Product.Price * orderdetail.Quantity;
        }

        public void GetOrderDetailInfo(OrderDetails orderDetail)
        {
            Console.WriteLine($" Quantity: {orderDetail.Quantity}");
        }

        public void UpdateQuantity(OrderDetails orderdetail, int newQuantity)
        {
            orderdetail.Quantity = newQuantity;
        }
    }
}
