using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Group.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}