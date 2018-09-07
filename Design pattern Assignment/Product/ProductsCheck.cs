using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ProductsCheck:Products
    {
        public override IProduct GetProduct(string desc)
        {
            switch (desc)
            {
                case "Car":
                    return new CarProduct();
                case "Air":
                    return new AirProduct();
                case "Hotel":
                    return new HotelProduct();
                case "Activity":
                    return new ActivityProduct();
                default:
                    return new Message(); 
            }
        }
    }
}
