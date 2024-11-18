using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
namespace Project2WooxTravel.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        TravelContext context=new TravelContext();

        [HttpPost]
        public ActionResult ReservationList(  int id)
        {         
            return View();
        }
        public ActionResult CreateReservation(Reservation reservation, Destination destination)
        {
            if (ModelState.IsValid)
            {
                int id = 0;
                context.Reservations.Add(reservation);
                context.SaveChanges();

                ViewBag.SuccessMessage = "Rezervasyon başarıyla eklendi!";
                var dest = context.Destinations.FirstOrDefault(x => x.DestinationId == id);

                return View("PartialTourDetail", id); // Modeli gönderin
            }

            return View();


        }
    }
}