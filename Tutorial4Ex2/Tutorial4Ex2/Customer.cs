using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex2
{
    class Customer
    {
        int id { get; set; }
        String name { get; set; }
        public Customer (int i, string n)
        {
            id = i;
            name = n;
        }

        static void Main(string[] args)
        {
            Customer Cust1 = new Customer();
            Customer Cust2 = new Customer();


        }
    }
}
