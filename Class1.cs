using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productdemo
{
    internal class Product
    {
        private int id;
        private string name;
        double price;

        public void add(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string Print()
        {
            return $" Product:{id}/{name}/{price}";
        }
    }
}

