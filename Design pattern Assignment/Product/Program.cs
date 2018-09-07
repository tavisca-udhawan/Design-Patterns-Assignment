using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Product
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger logging = Logger.SingleInstance;
            Products factory = new ProductsCheck();
            logging.LogMessage("Called Main Function()");
            while (true)
            {
                Console.WriteLine("Our Products are:");
                Console.WriteLine("----Car----------");
                Console.WriteLine("----Hotel--------");
                Console.WriteLine("----Air----------");
                Console.WriteLine("----Activity-----");
                Console.WriteLine("Enter Product name:");
                string description = Console.ReadLine();
                Console.Clear();
                IProduct product = factory.GetProduct(description);
                product.GetTypeOfProduct();
                if (product.GetTypeOfProduct() != "Invalid")
                {
                    logging.LogMessage("Selected" + product.GetTypeOfProduct() + "Product");
                    Console.WriteLine("Enter Option:");
                    Console.WriteLine("1----Book Product");
                    Console.WriteLine("2----Save Product");
                    Console.WriteLine("3----to Exit");
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value == 1)
                    {
                        logging.LogMessage("selected option to book product");
                        product.Book(product.GetTypeOfProduct());
                        product.Save(product.GetTypeOfProduct());
                    }
                    else if (value == 2)
                    {
                        logging.LogMessage("selected option to save product");
                        product.Save(product.GetTypeOfProduct());
                    }
                    else if (value == 3)
                    {
                      logging.LogMessage("Exit from Program");
                        Environment.Exit(0);
                    }
                    else
                    {
                        logging.LogMessage("Invalid Option");
                        Console.WriteLine("Invalid Option");
                    }
                }
                else
                {
                    logging.LogMessage("Entered Invalid Product");
                    Console.WriteLine("You entered Invalid product");
                }
            }
                //Console.ReadKey();
            
        }
    }
}
