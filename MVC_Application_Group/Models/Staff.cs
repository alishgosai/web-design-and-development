using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Group.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
    }
}