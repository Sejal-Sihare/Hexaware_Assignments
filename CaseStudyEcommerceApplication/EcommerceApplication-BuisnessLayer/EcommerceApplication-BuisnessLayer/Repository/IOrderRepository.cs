using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Repository
{
     public interface IOrderRepository
    {
        bool placeOrder(Orders order);
        List<Products> getOrderByCustomer(int Customer_ID);
    }
}
