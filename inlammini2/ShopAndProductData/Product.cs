using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{
    public class Product
    {


        public double Price { get; private set; }


        public string Name { get; private set; }
        public string Description { get; private set; }


        public Product(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;

        }


    }
}