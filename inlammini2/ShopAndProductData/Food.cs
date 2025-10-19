using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{
    class Food : Product
    {
        public int UseByDate { get; private set; }
        public Food(string name, double price, string description, int usebydate) : base(name, price, description)
        {

            UseByDate = usebydate;

        }

    }
}