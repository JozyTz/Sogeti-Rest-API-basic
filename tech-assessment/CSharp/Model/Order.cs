using System;
using System.Collections.Generic;

namespace CSharp.Model
{
    public class Order
    {
        public int orderId {get; set;}
        public int customerId {get; set;}
        public string orderName {get; set;}
        public Order(){}
        public Order(int orderId, int customerId, string orderName)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.orderName = orderName;
        }
    }
}
