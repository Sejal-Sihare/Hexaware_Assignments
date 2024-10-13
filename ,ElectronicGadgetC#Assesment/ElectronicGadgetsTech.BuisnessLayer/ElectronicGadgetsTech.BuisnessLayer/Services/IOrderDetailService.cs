using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Services
{
    public interface IOrderDetailService
    {
        decimal CalculateSubtotal(Products product, OrderDetails orderdetail);

        void GetOrderDetailInfo(OrderDetails orderDetail);

        void UpdateQuantity(OrderDetails orderdetail, int newQuantity);

        void AddDiscount(decimal discountAmount);
    }
}
