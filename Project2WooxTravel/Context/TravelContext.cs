using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project2WooxTravel.Entities;
namespace Project2WooxTravel.Context
{
    public class TravelContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


    }
}