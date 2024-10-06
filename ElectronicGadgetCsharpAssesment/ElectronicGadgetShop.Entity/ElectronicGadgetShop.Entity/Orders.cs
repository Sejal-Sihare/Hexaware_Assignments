using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetShop.Entity
{
    public class Orders
    {
        public int OrderID { get; set; }
       
        public Customers Customer { get; set; }
        
        public DateTime OrderDate { get; set; }
       
        public decimal TotalAmount { get; set; }
       
    }
}
