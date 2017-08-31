using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Solu.OrderGenerator
{
    class GenerateOrders
    {
        public List<OrdersObjL1> ConstructOrders()
        {
            Random RandomNums = new Random();
            List<OrdersObjL1> OrdersList = new List<OrdersObjL1>();
            #region Three_Objs
            OrdersObjL1 O0 = new OrdersObjL1
            {
                OrderId = 0,
                OrderDate = DateTime.Now.AddDays(-1),
                CustomerName = "Cust0",
                OrderAmount = 33.33M,
                OrderItems = new List<OrderItemL1>
                {
                    new OrderItemL1() { OrderItemId = 0, ProductName = "PdName0", Qty = RandomNums.Next(1, 100) },
                    new OrderItemL1 { OrderItemId = 1, ProductName = "PdName1", Qty = RandomNums.Next(1, 100) },
                    new OrderItemL1 { OrderItemId = 2, ProductName = "PdName2", Qty = RandomNums.Next(1, 100) }
                },
                BillingAddress = new OrderAddressL1
                {
                    Address1 = "b-Addr1",
                    City = "b-City1",
                    State = "b-State1",
                    Zip = "b-Zip1111"
                },
                ShippingAddress = new OrderAddressL1
                {
                    Address1 = "s-Addr1",
                    City = "s-City1",
                    State = "s-State1",
                    Zip = "s-Zip1111"
                }
            };

            OrdersObjL1 O1 = new OrdersObjL1(1, DateTime.Now) {
                CustomerName = "Cust1", OrderAmount = 33.333M,
                OrderItems = new List<OrderItemL1>
                {
                    new OrderItemL1() { OrderItemId = 3, ProductName = "PdName3", Qty = RandomNums.Next(1, 100) },
                    new OrderItemL1() { OrderItemId = 4, ProductName = "PdName4", Qty = RandomNums.Next(1, 100) }
                },
                BillingAddress = new OrderAddressL1
                {
                    Address1 = "b-Addr2",
                    City = "b-City2",
                    State = "b-State2",
                    Zip = "b-Zip2222"
                },
                ShippingAddress = new OrderAddressL1
                {
                    Address1 = "s-Addr2",
                    City = "s-City2",
                    State = "s-State2",
                    Zip = "s-Zip2222"
                }
            };

            OrdersObjL1 O2 = new OrdersObjL1(2, DateTime.Now.AddDays(1)) {
                CustomerName = "Cust2", OrderAmount = 333.333M,
                OrderItems = new List<OrderItemL1>
                {
                    new OrderItemL1() { OrderItemId = 5, ProductName = "PdName5", Qty = RandomNums.Next(1, 100) },
                    new OrderItemL1() { OrderItemId = 6, ProductName = "PdName6", Qty = RandomNums.Next(1, 100) },
                    new OrderItemL1() { OrderItemId = 7, ProductName = "PdName7", Qty = RandomNums.Next(1, 100) }
                },
                BillingAddress = new OrderAddressL1
                {
                    Address1 = "b-Addr3",
                    City = "b-City3",
                    State = "b-State3",
                    Zip = "b-Zip3333"
                },
                ShippingAddress = new OrderAddressL1
                {
                    Address1 = "s-Addr3",
                    City = "s-City3",
                    State = "s-State3",
                    Zip = "s-Zip3333"
                }
            };
            #endregion

            OrdersList.Add(O0);
            OrdersList.Add(O1);
            OrdersList.Add(O2);
            return OrdersList;
        }
    }
}
