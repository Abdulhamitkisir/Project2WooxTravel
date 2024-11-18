using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        TravelContext context=new TravelContext();
        public ActionResult Index()
        {
            var a=Session["x"];
            var values=context.Admins.Where(x=>x.Username==a).FirstOrDefault();
            return View(values);
        }
        public ActionResult ProfilDetails() 
        {        
            var a=Session["y"];
            var values = context.Admins.Where(x=> x.Email==a).ToList();
            return View(values);
        }
    }
}