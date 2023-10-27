using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Emin",
                Surname = "Tütün",
                Adress = "Tütün"
            };
            Student student = new Student
            {
                Id = 1,
                Name = "Yusuf Enes",
                Surname = "Tütün",
                Departmant = "Computer Science"
            };
            manager.Add(student);
            manager.Add(customer);
        }

        interface IPerson
        {
            int Id { get; set; }
            string Name { get; set; }
            string Surname { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Departmant { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.Name);
            }

        }
    }
}
