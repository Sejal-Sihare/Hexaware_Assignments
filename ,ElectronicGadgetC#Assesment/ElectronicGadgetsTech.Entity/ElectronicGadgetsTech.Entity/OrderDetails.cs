﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.Entity
{
    public class OrderDetails
    {

        public int OrderDetailID { get; set; }

        public Orders Order { get; set; }

        public Products Product { get; set; }

        public int Quantity { get; set; }

    }
}
