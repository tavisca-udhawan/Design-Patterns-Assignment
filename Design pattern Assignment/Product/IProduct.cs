using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public interface IProduct
    {
        string ProductName { get;set; }
        bool IsBooked { get; set; }
        int Fare { get; set; }
        string ProductId { get; set; }
        string ProductDesc { get; set; }
        string GetTypeOfProduct();
        void Save(string product);
        void Book(string product);
    }
}
