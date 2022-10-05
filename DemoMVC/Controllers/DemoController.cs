using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public string Test1()
        {
            string hello = " hello class dhcntt19a....";
            return hello;
        }

        public ActionResult Test2()
        {
            return View();
        }
    }
}