using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface IRepository
    {
       void InsertDataToDatabase(string id, string name, string desc,string product,int Fare,bool isBook);
       void InsertDataToFile(string ProductName, string ProductId, string ProductDesc,int Fare,bool isBook);
    }
}
