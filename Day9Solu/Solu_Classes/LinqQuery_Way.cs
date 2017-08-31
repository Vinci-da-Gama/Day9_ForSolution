using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day9Solu.OrderGenerator;

namespace Day9Solu.Solu_Classes
{
    class LinqQuery_Way
    {
        public void DisplayLinqQueryWay()
        {
            #region Get_Orders_List
            List<OrdersObjL1> ol = new List<OrdersObjL1>();
            GenerateOrders geos = new GenerateOrders();
            ol = geos.ConstructOrders();
            #endregion

            Console.WriteLine("21 -- Find Order after Today.");
            var a0 = from i in ol
                     where i.OrderDate > DateTime.Now
                     select i;
            foreach (var i in a0)
            {
                Console.WriteLine(String.Format("27 -- Date: {0} -- OrderId: {1}.", i.OrderDate, i.OrderId));
            }

            Console.WriteLine("\n30 -- Find Order after Today -- but collect OrderId and OrderAmt into Anonymous Type.");
            var a1 = from i in ol
                     where i.OrderDate > DateTime.Now
                     select new { i.OrderId, i.OrderAmount };
            foreach (var i in a1)
            {
                Console.WriteLine(String.Format("36 -- OrderId: {0} -- OrderAmt: {1}.\n", i.OrderId, i.OrderAmount));
            }

            Console.WriteLine("\n Find Max Amount");
            var a2 = (from i in ol
                      orderby i.OrderAmount descending
                      select i).First();
            Console.WriteLine(String.Format("43 -- OrderId: {0} -- OrderAmt: {1}.", a2.OrderId, a2.OrderAmount));

            Console.WriteLine("\nFind any OrderItems has Qty...");
            var a3 = from i in ol
                     where i.OrderItems.Any(p => p.Qty > 2)
                     select i;
            foreach (var i in a3)
            {
                Console.WriteLine(String.Format("51 -- OrderId: {0}.", i.OrderId));
            }

            Console.WriteLine("\n54 -- Sum up all Order Amount...");
            var a4 = (from i in ol
                      select i.OrderAmount).Sum();
            Console.WriteLine("\n Amount sum is: {0}.", a4);

            Console.WriteLine("\n What is average Order Amt...");
            var a5 = (from i in ol
                      select i.OrderAmount).Average();
            Console.WriteLine("62 -- Qty average is: {0}", a5);

            Console.WriteLine("\n How many Orders has multiple Items?");
            var a6 = (from i in ol
                      where i.OrderItems.Count > 1
                      select i).Count();
            Console.WriteLine("How many Orders has multiple Items? -- {0}.", a6);

            Console.WriteLine("\n Create Flat list and project OrderId, OrderItemId, ProductName, Qty");
            var a7 = from i in ol
                     from oi in i.OrderItems
                     select new { i.OrderId, oi.OrderItemId, oi.ProductName, oi.Qty };
            foreach (var i in a7)
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}. ", i.OrderId, i.OrderItemId, i.ProductName, i.Qty);
            }

            Console.WriteLine("\n Create New Order -->  add 1000 to each OrderId and Set All OrderDate to Now.");
            var a8 = from k in ol
                     select new OrdersObjL1
                     {
                         OrderId = k.OrderId + 1000,
                         OrderDate = DateTime.Now,
                         CustomerName = k.CustomerName,
                         OrderAmount = k.OrderAmount,
                         OrderItems = k.OrderItems,
                         BillingAddress = k.BillingAddress,
                         ShippingAddress = k.ShippingAddress
                     };
            foreach (var i in a8)
            {
                Console.WriteLine("78 -- OrderId: {0} -- OrderDate: {1} -- OrderAmt: {2}.", i.OrderId, i.OrderDate.ToShortDateString(), i.OrderAmount);
            }

        }
    }
}
