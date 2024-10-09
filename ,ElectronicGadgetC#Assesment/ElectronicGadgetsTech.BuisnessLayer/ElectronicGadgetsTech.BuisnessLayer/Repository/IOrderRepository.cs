﻿using ElectronicGadgetsTech.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGadgetsTech.BuisnessLayer.Repository
{
    public interface IOrderRepository
    {

        decimal CalculateTotalAmount(Orders order);

        void GetOrderDetails(Orders order, Customers customer);

        void UpdateOrderStatus(Orders order);

        void CancelOrder();

    }
}
