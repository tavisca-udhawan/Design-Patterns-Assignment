using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Message : IProduct
    {
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        public string ProductDesc { get; set; }
        public bool IsBooked { get; set; }
        public int Fare { get; set; }

        public void Book(string product)
        {
            Console.WriteLine("");
        }

        public string GetTypeOfProduct()
        {
           return "Invalid";
        }

        public void Save(string product)
        {
            Console.WriteLine("");
        }
    }
}
