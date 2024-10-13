using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public interface IOrderService
    {
        bool placeOrder(Orders order);
        List<Products> getOrderByCustomer(int Customer_ID);
    }
}
