﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testgapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. v2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.V2";

            return View();
        }
    }
}