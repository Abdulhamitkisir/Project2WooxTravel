using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
                
        TravelContext context=new TravelContext();
        [Authorize]
        public ActionResult CategoryList()
        {
            var values= context.Categories.ToList();
            return View(values);
        }
    }
}