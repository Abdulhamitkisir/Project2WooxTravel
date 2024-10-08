using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string MapLocation { get; set; }
    }
}