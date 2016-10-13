using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyA.Orders;

namespace CompanyA.OrderEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Product Id");
            string id = Console.ReadLine();
            Console.WriteLine("The Product Id is {0}", OrderValidation.IsProductValid(id) ? "valid" : "invalid");
        }
    }
}
