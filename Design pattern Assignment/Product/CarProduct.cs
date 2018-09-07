using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class CarProduct:IProduct
    {
        string name = "Mercedes benz";
        string Id = "CAR1";
        string Desc = "Mercedes A class";
        public bool IsBook = false;
        public int fare = 500;
        Logger logging = Logger.SingleInstance;
        public string ProductName { get { return name; } set { ProductName = value; } }
        public string ProductId { get { return Id; } set { ProductId = value; } }
        public string ProductDesc { get { return Desc; } set { ProductDesc = value; } }
        public bool IsBooked { get { return IsBook; } set { IsBooked = value; } }
        public int Fare { get { return fare; } set { Fare = value; } }

        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Book(string product)
        {
           Strategy fareCheck = new Strategy();
            fare = fareCheck.CalculateTotalFare(fare, "Car");
            IsBook = true;
            Console.WriteLine("Booking Car Product");
            logging.LogMessage("car product has been booked");
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
                Console.WriteLine("Car Product has been saved");
                logging.LogMessage("Car Product has been saved in database");
            }
            else if (data == 2) {

                database.InsertDataToFile(ProductName, ProductId, ProductDesc,Fare,IsBook);
                logging.LogMessage("Car Product has been saved in file");
                Console.WriteLine("Car Product has been saved");
            }
            else
            {
                Console.WriteLine("Invalid data");
            }

        }
    }
}
