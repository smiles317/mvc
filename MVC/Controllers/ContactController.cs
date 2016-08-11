﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        // GET: Contact/Showing
        public ActionResult Showing()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }
    }
}