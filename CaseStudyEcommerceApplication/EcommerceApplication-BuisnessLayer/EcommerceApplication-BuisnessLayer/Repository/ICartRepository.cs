using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Repository
{
   public interface ICartRepository
    {

        bool addToCart( int Cart_ID,Products product, Customers customer,int Quantity);

        bool removeFromCart(int Cart_Id);

        List<Products> getAllFromCart(int Customer_ID);
    }
}
