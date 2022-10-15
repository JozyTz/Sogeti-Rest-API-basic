using CSharp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Controllers
{
    [ApiController]
    [Route("")]
    public class OrdersController : ControllerBase
    {
        private List<Order> ordersDb = new List<Order>(){
            new Order(1, 1, "Cust1Order1"),
            new Order(2, 2, "Cust2Order1"),
            new Order(3, 3, "Cust3Order1"),
            new Order(4, 1, "Cust1Order2"),
            new Order(5, 2, "Cust2Order2"),
            new Order(6, 3, "Cust3Order2"),
        };

        [HttpPost]
        public List<Order> CreateOrder([FromBody] Order order)
        {
            Random rand = new Random();
            order.orderId = rand.Next();
            ordersDb.Add(order);
            return ordersDb;
        }

        [HttpGet]
        public List<Order> GetOrdersByCustomer([FromQuery] int custId)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in ordersDb)
            {
                if (order.customerId == custId)
                {
                    orders.Add(order);
                }
            }
            return orders;
        }

        [HttpGet("orders")]
        public List<Order> GetAllOrders()
        {
            return ordersDb;
        }

        [HttpPut]
        public List<Order> UpdateOrder([FromBody] Order ord)
        {
            int size = ordersDb.Count();
            ordersDb.RemoveAll(order => order.orderId == ord.orderId);
            if (ordersDb.Count() != size)
            {
                ordersDb.Add(ord);
            }
            return ordersDb;
        }

        [HttpDelete]
        public List<Order> CancelOrder([FromQuery] int ordId)
        {
            ordersDb.RemoveAll(order => order.orderId == ordId);
            return ordersDb;
        }
    }
}
