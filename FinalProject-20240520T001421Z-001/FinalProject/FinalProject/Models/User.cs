using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required ]
        public string Username { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
    public class Staff : User
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
    }
    public class Customer : User
    {
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
    }

}