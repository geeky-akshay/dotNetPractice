using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Data;
using NerdDinner.Models;

namespace NerdDinner.Controllers
{
    public class HomeController : Controller
    {
        private NerdDinnersContext nerdContext = new NerdDinnersContext();
        // GET: Home
        public ActionResult Index()
        {
            var dinners = from d in nerdContext.Dinners
                          where d.EventDate > DateTime.Now
                          select d;

            return View(dinners.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                nerdContext.Dinners.Add(dinner);
                nerdContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(dinner);
        }
    }
}