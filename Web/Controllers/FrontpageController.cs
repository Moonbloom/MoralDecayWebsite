﻿using System.Web.Mvc;

namespace Web.Controllers
{
    public class FrontpageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}