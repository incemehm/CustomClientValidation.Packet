using CustomClientValidation.Sample.Models;
using System;
using System.Web.Mvc;

namespace CustomClientValidation.Sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Home/
        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (ModelState.IsValid)
                Console.WriteLine("There is something wrong!");

            return View(model);
        }
    }
}