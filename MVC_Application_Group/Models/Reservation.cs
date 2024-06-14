using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Group.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}