using System;
using System.Net.Mail;
using System.Web.Mvc;
using _4thJune.Models;

namespace _4thJune.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PartyInfo()
        {
            ViewBag.Message = "Your Party page.";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Your Party page.";

            return View();
        }

        public ActionResult Locations()
        {
            ViewBag.Message = "Your Party page.";

            return View();
        }

        public ActionResult Telegram()
        {
            ViewBag.Message = "Your Party page.";

            return View();
        }

        public ActionResult PracticalInfo()
        {
            ViewBag.Message = "Your Party page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Gifts()
        {
            return View();
        }

        public ActionResult RegistrationSent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string firstname, string lastname, string mobile, string email, string answer)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Registrations.Add(new Registration
            {
                Id = Guid.NewGuid(),
                Created = DateTime.Now,
                Email = email,
                Firstname = firstname,
                Lastname = lastname,
                Message = answer,
                Mobile = mobile,
            });
            context.SaveChanges();
            //MailMessage message = new MailMessage();
            //message.To.Add(new MailAddress("pjinnipedia@gmail.com"));
            //message.Subject = "Bröllopsanmälan";
            return View("RegistrationSent");
        }
    }
}