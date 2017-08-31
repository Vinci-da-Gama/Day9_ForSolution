using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Solu.OrderGenerator
{
    class OrdersObjL1
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public List<OrderItemL1> OrderItems { get; set; }
        public OrderAddressL1 BillingAddress { get; set; }
        public OrderAddressL1 ShippingAddress { get; set; }

        public OrdersObjL1()
        {
            OrderItems = new List<OrderItemL1>();
        }
        public OrdersObjL1(int Oid, DateTime dt)
        {
            OrderId = Oid;
            OrderDate = dt;
        }

    }
}
