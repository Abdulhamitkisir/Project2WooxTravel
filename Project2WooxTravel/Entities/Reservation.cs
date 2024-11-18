using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace Project2WooxTravel.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public int DestinationId { get; internal set; }
    }
}