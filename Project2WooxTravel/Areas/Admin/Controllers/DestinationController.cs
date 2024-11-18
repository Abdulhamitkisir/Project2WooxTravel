using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using PagedList;
namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    //[AllowAnonymous] Mevcuttaki butun kurallardan muhagfiyet saglar. Loginsiz islem yapabilir.
    public class DestinationController : Controller
    {
        // GET: Admin/Destination
        TravelContext context=new TravelContext();
        public ActionResult DestinationList()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }
        //public ActionResult DestinationList(int page=1)
        //{
        //    var values = context.Destinations.ToList().ToPagedList(page,5);
        //    return View(values);
        //}
        public ActionResult CreateDestination() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDestination(Destination destination)
        {
            context.Destinations.Add(destination);
            context.SaveChanges();
            return RedirectToAction("DestinationList","Destination","Admin");
        }
        public ActionResult DeleteDestination(int id)
        {
            var value = context.Destinations.Find(id);
            context.Destinations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("DestinationList","Destination", "Admin");
        }
        [HttpGet]
        public ActionResult UpdateDestination(int id)
        { 
            var value=context.Destinations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateDestination(Destination destination)
        {
            var value = context.Destinations.Find(destination.DestinationId);
            value.Description= destination.Description;
            value.City= destination.City;
            value.Country= destination.Country;
            value.DayNight= destination.DayNight;
            value.Title= destination.Title;
            value.Price= destination.Price;
            value.ImageUrl= destination.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");

        }
    }
}