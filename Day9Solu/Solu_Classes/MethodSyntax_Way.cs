using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day9Solu.OrderGenerator;

namespace Day9Solu.Solu_Classes
{
    class MethodSyntax_Way
    {
        public void DisplayMethodSytaxWay()
        {
            #region Get_Orders_List
            List<OrdersObjL1> ol = new List<OrdersObjL1>();
            GenerateOrders geos = new GenerateOrders();
            ol = geos.ConstructOrders();
            #endregion

            Console.WriteLine("21 -- Find Order Later than Today.");
            var a0 = ol.Where( o => o.OrderDate > DateTime.Now );
            foreach (var i in a0)
            {
                Console.WriteLine(String.Format("25 -- Date: {0} -- OrderId: {1}.", i.OrderDate, i.OrderId));
            }

            Console.WriteLine("28 -- Find Order Later than Today -- but collect OrderId and OrderAmt into Anonymous Type.");
            var a1 = ol.Where(o => o.OrderDate > DateTime.Now).Select( p => new { p.OrderId, p.OrderAmount } );
            foreach (var i in a1)
            {
                Console.WriteLine(String.Format("25 -- OrderId: {0} -- OrderAmt: {1}.", i.OrderId, i.OrderAmount));
            }

            Console.WriteLine("\n Find Max Amount");
            var a2 = ol.OrderByDescending(o => o.OrderAmount).First();
            Console.WriteLine(String.Format("25 -- OrderId: {0} -- OrderAmt: {1}.", a2.OrderId, a2.OrderAmount));

            Console.WriteLine("\nFind any OrderItems has Qty...");
            var a3 = ol.Where(o => o.OrderItems.Any(p => p.Qty > 2));
            foreach (var i in a3)
            {
                Console.WriteLine(String.Format("43 -- OrderId: {0}.", i.OrderId));
            }

            Console.WriteLine("\n41 -- Sum up all Order Amount...");
            var a4 = ol.Select(o => o.OrderAmount).Sum();
            Console.WriteLine("\n Amount sum is: {0}.", a4);

            Console.WriteLine("\n What is average Order Qty...");
            var a5 = ol.SelectMany(p => p.OrderItems.Select(k => k.Qty)).Average();
            Console.WriteLine("52 -- Qty average is: {0}", Math.Round(a4, 1));

            Console.WriteLine("\n How many Orders has multiple Items?");
            var a6 = ol.Count(p => p.OrderItems.Any(r => r.Qty > 1));
            Console.WriteLine("How many Orders has multiple Items? -- {0}.", a6);

            Console.WriteLine("\n Create Flat list and project OrderId, OrderItemId, ProductName, Qty");
            var a7 = ol.SelectMany(o => o.OrderItems, (o, oi) => new { o.OrderId, oi.OrderItemId, oi.ProductName, oi.Qty });
            foreach (var i in a7)
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}. ", i.OrderId, i.OrderItemId, i.ProductName, i.Qty);
            }

            Console.WriteLine("\n Create New Order -->  add 1000 to each OrderId and Set All OrderDate to Now.");
            var a8 = ol.Select(o => new OrdersObjL1 {
                OrderId = o.OrderId + 1000,
                OrderDate = DateTime.Now,
                CustomerName = o.CustomerName,
                OrderAmount = o.OrderAmount,
                OrderItems = o.OrderItems,
                BillingAddress = o.BillingAddress,
                ShippingAddress = o.ShippingAddress
            });

            foreach (var i in a8)
            {
                Console.WriteLine("78 -- OrderId: {0} -- OrderDate: {1} -- OrderAmt: {2}.", i.OrderId, i.OrderDate.ToShortDateString(), i.OrderAmount);
            }

        }
    }
}
