using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Group.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // e.g., "Customer", "Staff"
    }
}