using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string SName { get; set; }
        public string SEmail { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}