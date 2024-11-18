using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
        TravelContext context=new TravelContext();
        public ActionResult Index()
        {           
            var b=context.Admins.ToList();
            return View(b);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar() 
        {
            return PartialView();             
        }
        public PartialViewResult PartialNavbar() 
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter() 
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNotification() 
        {
            var values = context.Destinations.OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return PartialView(values);
        }
    }
}