using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        public int TableNumber { get; set; }

        [DataType (DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }
        public int PartySize { get; set; }
    }
}