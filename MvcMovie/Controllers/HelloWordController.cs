﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: HelloWord
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTime = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTime;
            return View();
        }
    }
}