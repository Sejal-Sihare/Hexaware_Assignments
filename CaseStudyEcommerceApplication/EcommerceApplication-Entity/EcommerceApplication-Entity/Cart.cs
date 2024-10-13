using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication_Entity
{
  public class Cart
    {
        public string Cart_Id {  get; set; }
        public int Customer_ID { get; set; }
        public int Product_ID {  get; set; }

        public int Quantity {  get; set; } 
        
        }
}
