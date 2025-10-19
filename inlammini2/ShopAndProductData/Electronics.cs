using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{

    class Electronics : Product
    {

        public string OsType { get; private set; }
        public string Brand { get; private set; }
        public string Type { get; private set; }

        public int WarrantyMonths { get; private set; }
        public Electronics(string name, double price, string description, string brand, string osType, string type, int warrantyMonths) : base(name, price, description)
        {

            OsType = osType;
            Brand = brand;
            Type = type;
            WarrantyMonths = warrantyMonths;
        }




    }
}
