﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Models.BoksiDB _db = new Models.BoksiDB();

        public ActionResult Index()
        {
            var model = _db.Tilaukset.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tilaus()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();
            base.Dispose(disposing);
        }
    }
}