using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class AirProduct : IProduct
    {
        string name = "AirIndia";
        string Id = "AIR1";
        string Desc = "Air Product";
        public bool IsBook = false;
        int fare = 3000;
        Logger logging = Logger.SingleInstance;
        public int Fare { get { return fare; } set { Fare = value; } }
        public string ProductName { get { return name; } set { ProductName = value; } }
        public string ProductId { get { return Id; } set { ProductId = value; } }
        public string ProductDesc { get { return Desc;} set { ProductDesc = value; } }
        public bool IsBooked { get { return IsBook; } set { IsBooked = value; } }
        public string GetTypeOfProduct()
            {
                return "Air";
            }
            public void Book(string product)
        {
            Strategy fareCheck = new Strategy();
            fare = fareCheck.CalculateTotalFare(fare, "Air");
            IsBook = true;
            Console.WriteLine("Booking Air Product");
            logging.LogMessage("Air product has been booked");
        }
            public void Save(string product)
        {

            Console.WriteLine("Name: " + ProductName + " Id: " + ProductId + " Description: " + ProductDesc + " price: " + fare);
            Repository database = new Repository();
            Console.WriteLine("Enter Option:");
            Console.WriteLine("1----Save in database");
            Console.WriteLine("2----Save in TextFile");
            int data = Convert.ToInt32(Console.ReadLine());
            if (data == 1)
            {
                database.InsertDataToDatabase(ProductName, ProductId, ProductDesc, product,Fare,IsBook);
                Console.WriteLine("Air Product has been saved");
                logging.LogMessage("Air Product has been saved in database");
            }
            else if (data == 2)
            {
                database.InsertDataToFile(ProductName, ProductId, ProductDesc,Fare,IsBook);
                logging.LogMessage("Air Product has been saved in file");
                Console.WriteLine("Air Product has been saved");
            }
            else
            {
                logging.LogMessage("Invalid Data");
                Console.WriteLine("Invalid data");
            }

        }
    }
}
