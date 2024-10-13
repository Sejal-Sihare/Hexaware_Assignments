using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_Entity
{
   public class Orders
    {
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public DateTime OrderDate {  get; set; }
         public int Total_Price {  get; set; }

        public string ShippingAddress {  get; set; }   
        
        }
}
