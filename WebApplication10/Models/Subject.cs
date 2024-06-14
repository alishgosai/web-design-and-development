using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubName { get; set; }
        public int credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}