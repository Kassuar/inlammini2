using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{

    class Clothes : Product
    {
        public string Brand { get; private set; }
        public string Size { get; private set; }
        public Clothes(string name, double price, string description, string brand, string size) : base(name, price, description)
        {
            Brand = brand;
            Size = size;
        }
    }
}
