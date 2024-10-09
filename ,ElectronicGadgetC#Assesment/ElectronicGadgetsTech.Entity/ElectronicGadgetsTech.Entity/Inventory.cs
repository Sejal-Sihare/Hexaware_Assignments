using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.Entity
{
   public class Inventory
    {
        public int InventoryID { get; set; }

        public Products Product { get; set; }

        public int QuantityInStock { get; set; }

        public DateTime LastStockUpdate { get; set; }
    }
}
