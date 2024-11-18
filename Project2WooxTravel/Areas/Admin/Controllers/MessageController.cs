using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Admin/Message
        public ActionResult Inbox()
        {
            var a = Session["x"];
            var email=context.Admins.Where(x=> x.Username==a).Select(y=>y.Email).FirstOrDefault();
            var values=context.Messages.Where(x=> x.ReceiverMail ==email).ToList();
            return View(values);
        }
        public ActionResult SendBox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderMail == email).ToList();
            return View(values);
        }
        public ActionResult SendMessage() 
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a).Select(y => y.Email).FirstOrDefault();
            message.SenderMail= email;
            message.SendDate= DateTime.Now;
            message.IsRead= false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("SendBox","Message", new { area="Admin"});
        }
        public ActionResult UnReadMessage(Message message)
        {
            var b = Session["y"];
            // var mail = context.Messages.Where(x => x.ReceiverMail == b);
            var values = context.Messages.Where(x => x.ReceiverMail == b).ToList();
            return View(values);
        }
        [HttpPost]
        public ActionResult MarkAsRead(int messageId)
        {
            var message = context.Messages.FirstOrDefault(m => m.MessageId == messageId);
            if (message != null)
            {
                message.IsRead = true;
                context.SaveChanges();  // Değişiklikleri veritabanına kaydediyoruz
            }

            // Yönlendirme işlemi: Kullanıcı inbox sayfasına geri yönlendiriliyor
            return RedirectToAction("Inbox");
        }
    }
}