using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface IFare
    {
        int CalculateTotalFare(int fare,string product);
    }
}
