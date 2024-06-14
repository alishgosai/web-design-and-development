using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        public int TableNumber { get; set; }

 
        public DateTime OrderDateTime { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}