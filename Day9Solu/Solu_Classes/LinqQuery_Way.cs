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
        public void DisplayMethodSytaxWay()
        {
            #region Get_Orders_List
            List<OrdersObjL1> ol = new List<OrdersObjL1>();
            GenerateOrders geos = new GenerateOrders();
            ol = geos.ConstructOrders();
            #endregion

            Console.WriteLine("21 -- Find Order Later than Today.");

            Console.WriteLine("28 -- Find Order Later than Today -- but collect OrderId and OrderAmt into Anonymous Type.");

            Console.WriteLine("\n Find Max Amount");

            Console.WriteLine("\nFind any OrderItems has Qty...");

            Console.WriteLine("\n41 -- Sum up all Order Qty...");

            Console.WriteLine("\n What is average Order Qty...");

            Console.WriteLine("\n How many Orders has multiple Items?");

            Console.WriteLine("\n Create Flat list and project OrderId, OrderItemId, ProductName, Qty");

            Console.WriteLine("\n Create New Order -->  add 1000 to each OrderId and Set All OrderDate to Now.");
        }
    }
}
