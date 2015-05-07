using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var test = new ClassLibrary1.Class1();
            var model = new ContactViewModel()
            {
                Name = "John",
                Phone = "133 - 71 10 10"
            };

            return View(model);
        }

        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactForm(ContactFormModel model)
        {
            if (!ModelState.IsValid)
            {
                //ViewBag.Message = "Du nu missade du att fylla i något!";
                return View();
            }

            ViewBag.Message = "Vi kommer höra av oss snarast!";
            return View();
        }

        [HttpPost]
        public ActionResult Test(string username, string password)
        {
            if(username == "kebab" && password == "svarv")
                return Content("Woohooo!");

            return Content("Phaaail!");
        }
    }
}