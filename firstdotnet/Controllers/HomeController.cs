using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace firstdotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {

            ViewData["num1"] = id;
            ViewData["num2"] = "lkfhwe";

            return View();
        }


        public ActionResult Mynew(string msg)
        {
            ViewData["valofx"] = msg;

            return View();
        }

    }
}
