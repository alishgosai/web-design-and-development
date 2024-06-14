using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Product
        {
            public int pid { get; set; }
            public string pname { get; set; }
            public double price { get; set; }

        }
    class Customer
    {

        public int id { get; set; }
        public string name { get; set; }
        public List<Product> shopList = new List<Product>();
        public Customer(int i, string n)
        {
            id = i;
            name = n;
        }
        public void describe()
        {
        }



        class Program
        {
            static void Main(string[] args)
            {



                Customer cust1 = new Customer(101, "First Customer");
                Customer cust2 = new Customer(102, "Second Customer");

                Product p1 = new Product();
                Product p2 = new Product();

                p1.pid = 23;
                p1.price = 9.5;

                p2.pid = 33;
                p2.price = 5.5;
                cust1.shopList.Add(p1);
                cust2.shopList.Add(p2);

                Console.WriteLine("ID of !st customer:" + cust1.id);
                Console.WriteLine("name of second customer:" + cust2.name);
                Console.Read();
            }
        }
        
    }
}
