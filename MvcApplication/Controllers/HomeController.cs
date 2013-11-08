﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = string.Format("Du kjører versjon {0}", Assembly.GetExecutingAssembly().GetName().Version);
            ViewBag.Debug = "JAAA!";

#if DEBUG
            ViewBag.Debug = true;
#endif

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
