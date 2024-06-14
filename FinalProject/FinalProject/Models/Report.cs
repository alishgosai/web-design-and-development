using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public DateTime ReportDate { get; set; }

        public int PopularMenuItemID { get; set; }
        public Menu PopularMenuItem { get; set; }

        public int ReservationFrequency { get; set; }
    }
}