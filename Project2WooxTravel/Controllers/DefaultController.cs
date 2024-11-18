using System.Linq;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using PagedList;

namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var values = context.Destinations.Take(4).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCountry(int page=1)
        {
            var values = context.Destinations.ToList().ToPagedList(page,3);
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialTourDetail(int id)
        {
            var values = context.Destinations.Where(x => x.DestinationId == id).ToList();
            return PartialView(values);
        }
        public ActionResult PartialRoutes()
        {
            var values=context.Destinations.ToList();
            return View(values);
        }
        public ActionResult AboutPage()
        {
           return View();
        }
        public ActionResult Register()
        {

            return View();
        }
   
    }
}