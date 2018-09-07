using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Strategy:IFare
    {
        public int CalculateTotalFare(int fare,string product)
        {
            if (product == "Car")
                fare += (2 * fare) / 100;
            else if (product == "Air")
                fare += (4 * fare) / 100;
            else if (product == "Activity")
                fare += (8 * fare) / 100;
            else if (product == "Hotel")
                fare += (10 * fare) / 100;
            return fare;
        }
    }
}
