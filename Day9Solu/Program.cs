using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day9Solu.Solu_Classes;

namespace Day9Solu
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodSyntax_Way msw = new MethodSyntax_Way();
            msw.DisplayMethodSytaxWay();

            Console.WriteLine("\n Now Show Linq Query Way...\n");
            LinqQuery_Way lqw = new LinqQuery_Way();
            lqw.DisplayLinqQueryWay();

            Console.ReadLine();
        }
    }
}
