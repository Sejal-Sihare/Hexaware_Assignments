using EcommerceApplication_BuisnessLayer.Repository;
using EcommerceApplication_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_BuisnessLayer.Services
{
    public class CartService : ICartService
    {

       
        ICartRepository _cartRepository;
        public CartService(CartRepository cartRepository) {

            _cartRepository = cartRepository;
        
        }
        public bool addToCart(int Cart_ID, Products product, Customers customer, int Quantity)
        {
            return _cartRepository.addToCart(Cart_ID,product, customer, Quantity);
        }

        public List<Products> getAllFromCart(int Customer_ID)
        {
           return _cartRepository.getAllFromCart(Customer_ID);
        }

        public bool removeFromCart(int Cart_ID)
        {
            return _cartRepository.removeFromCart(Cart_ID);
        }
    }
}
