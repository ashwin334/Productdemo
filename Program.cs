using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.add(93, "Ashwin", 75.7);
            Console.WriteLine(p1.Print());
        }
    }
}
