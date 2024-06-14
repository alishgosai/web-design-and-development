﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Menu
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }


        public string Description { get; set; }

 
        public decimal Price { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}