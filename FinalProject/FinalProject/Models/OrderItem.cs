using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int MenuItemID { get; set; }
        public Menu Menu { get; set; }
        public int Quantity { get; set; }
    }
}