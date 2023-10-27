using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yusuf Enes";
            customer.LastName = "Tütün";
            customer.City = "Istanbul";

            Customer customer2 = new Customer { 
            
            Id = 2, City="İstanbul", FirstName="Emin", LastName="Tütün"
            };
            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    



    }


}
