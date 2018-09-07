using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class HotelProduct:IProduct
    {
        string name = "JW Marriot";
        string Id = "HOTEL1";
        string Desc = "Hotel Product(5 star)";
        public bool IsBook = false;
        int fare = 3500;
        public int Fare { get { return fare; } set { Fare = value; } }
        Logger logging = Logger.SingleInstance;
        public string ProductName { get { return name; } set { ProductName = value; } }
        public string ProductId { get { return Id; } set { ProductId = value; } }
        public string ProductDesc { get { return Desc; } set { ProductDesc = value; } }
        public bool IsBooked { get { return IsBook; } set { IsBooked = value; } }
        public string GetTypeOfProduct()
        {
            return "Hotel";
        }
        public void Book(string product)
        {
           Strategy fareCheck = new Strategy();
            fare = fareCheck.CalculateTotalFare(fare, "Hotel");
            IsBook = true;
            Console.WriteLine("Booking Hotel Product");
            logging.LogMessage("Hotel product has been booked");
        }
        public void Save(string product)
        {
            Console.WriteLine("Name: " + ProductName + " Id: " + ProductId + " Description: " + ProductDesc + " price: " + Fare);
            Repository database = new Repository();
            Console.WriteLine("Enter Option:");
            Console.WriteLine("1----Save in database");
            Console.WriteLine("2----Save in TextFile");
            int data = Convert.ToInt32(Console.ReadLine());
            if (data == 1)
            {
                database.InsertDataToDatabase(ProductName, ProductId, ProductDesc, product,Fare,IsBook);
                Console.WriteLine("Hotel Product has been saved");
                logging.LogMessage("Hotel Product has been saved in database");
            }
            else if (data == 2)
            {
                database.InsertDataToFile(ProductName,ProductId,ProductDesc,Fare,IsBook);
                logging.LogMessage("Hotel Product has been saved in file");
                Console.WriteLine("Hotel Product has been saved");
            }
            else
            {
                logging.LogMessage("Invalid Data");
                Console.WriteLine("Invalid data");
            }

        }
    }
}
